using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
     private readonly IPaymentService paymentService;

       public PaymentController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        [HttpGet]
        public List<Paymentac> GetAllPayment()
        {
            return paymentService.GetAllPayment();
        }
        [HttpPost]
        public void CreatePayment(Paymentac paymentac)
        {
            paymentService.CreatePayment(paymentac);
        }
        [HttpPut]
        public void UpdatePayment(Paymentac paymentac)
        {
            paymentService.UpdatePayment(paymentac);
        }
        [HttpDelete]
        public void DeletePayment(int id)
        {
            paymentService.DeletePayment(id);
        }

        //report
        [HttpGet]
        [Route("Report")]
        public List<Report> Reports()
        {
            return paymentService.Reports();
        }


        [HttpGet]
        [Route("payment/{id}")]
        public Paymentac GetPaymentbypatid(int id)
        {
            return paymentService.GetPaymentbypatid(id);
        }
    }
}
