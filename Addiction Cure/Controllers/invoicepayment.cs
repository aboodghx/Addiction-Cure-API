using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Net.Mail;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using MimeKit;
using IronPdf;
using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using Addiction_Cure.core.DTO;
using Google.Protobuf.Reflection;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class invoicepayment : ControllerBase
    {
        [HttpPost("pay")]
        public IActionResult CreatePayment([FromBody] PaymentRequest paymentRequest)
        {
            StripeConfiguration.ApiKey = "sk_test_51MbSgMC5iNj1HcZ7Tv1VlJBnKVvaKYT9c8g6j4AKZJivLI5FyXwmXKULrx9zd460qJzGo81leKa9JiJWP5VjBrq000sp9VMgWX";

            try
            {
                // Create PaymentMethod
                var cardoptions = new PaymentMethodCreateOptions
                {
                    Type = "card",
                    Card = new PaymentMethodCardOptions
                    {
                        Number = paymentRequest.cardNumber,
                        ExpMonth = paymentRequest.ExpMonth,
                        ExpYear = paymentRequest.ExpYear,
                        Cvc = paymentRequest.cvc,
                    },
                };
                var paymentMethodService = new PaymentMethodService();
                PaymentMethod paymentMethod = paymentMethodService.Create(cardoptions);

                // Create Customer
                var customerOptions = new CustomerCreateOptions
                {
                    Email = paymentRequest.Email,
                    Name = paymentRequest.Name,
                    Description = "My First Test Customer (created for API docs at https://www.stripe.com/docs/api)",
                };
                var customerService = new CustomerService();
                Customer customer = customerService.Create(customerOptions);

                // Attach PaymentMethod to Customer
                var paymentMethodAttachOptions = new PaymentMethodAttachOptions
                {
                    Customer = customer.Id,
                };
                paymentMethodService.Attach(paymentMethod.Id, paymentMethodAttachOptions);

                // Create Payment
                var paymentOptions = new PaymentIntentCreateOptions
                {
                    Amount = paymentRequest.Amount * 100,
                    Currency = "usd",
                    PaymentMethod = paymentMethod.Id,
                    Customer = customer.Id,
                    Confirm = true,
                    OffSession = true,
                };
                var paymentService = new PaymentIntentService();
                PaymentIntent paymentIntent = paymentService.Create(paymentOptions);

                //Send Invoice
                var Renderer = new ChromePdfRenderer();
                var pdf = Renderer.RenderHtmlAsPdf($"<h1>Thank you for your trust in us, and we will be at your best expectation of us, and throughout the period of your treatment, we will follow up your condition in cooperation with the best doctors.</h1>\r\n" +
                    $"\r\n Patient Name:{paymentRequest.Name}\r\n" +
                    $"\r\nPateint Addiction:{paymentRequest.CategoryName}\r\n" +
                    $"\r\nPateint Level:{paymentRequest.Level}\r\n" +
                    $"\r\nDate:{DateTime.Now}\r\n" +
                    $"\r\nAmount:{paymentRequest.Amount}$\r\n");
                pdf.SaveAs("Invoice.pdf");
                string x = "Thank you for your trust in us, and we will be at your best expectation of us, and throughout the period of your treatment, we will follow up your condition in cooperation with the best doctors.";

                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Addiction Cure", "abedabood009@gmail.com"));
                message.To.Add(MailboxAddress.Parse(paymentRequest.Email));
                message.Subject = "Invoice";
                var builder = new BodyBuilder();
                builder.TextBody = x;
//                builder.HtmlBody = "<h1>Thank you for your trust in us, and we will be at your best expectation of us, and throughout the period of your treatment, we will follow up your condition in cooperation with the best doctors.</h1>";
                builder.Attachments.Add(@"C:\Users\User\source\Repos\aboodapi\Addiction-Cure-master\Addiction Cure\Invoice.pdf");

                message.Body = builder.ToMessageBody();

                SmtpClient client = new SmtpClient();
                try
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate("abedabood009@gmail.com", "xjxdlshrldcnnmkz");
                    client.Send(message);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }

                return Ok("true");
            }
            catch
            {
                return BadRequest("fales");
            }
        }

    }
}
