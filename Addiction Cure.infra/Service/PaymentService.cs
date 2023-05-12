using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }

        public List<Paymentac> GetAllPayment()
        {
            return paymentRepository.GetAllPayment();
        }
        public void CreatePayment(Paymentac paymentac)
        {
            paymentRepository.CreatePayment(paymentac);
        }

        public void UpdatePayment(Paymentac paymentac)
        {
            paymentRepository.UpdatePayment(paymentac);
        }
        public void DeletePayment(int id)
        {
            paymentRepository.DeletePayment(id);
        }
        //report
        public List<Report> Reports()
        {
            return paymentRepository.Reports();
        }

        public Paymentac GetPaymentbypatid(int id)
        {
            return paymentRepository.GetPaymentbypatid(id);
        }
    }
}
