using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Service
{
    public interface IPaymentService
    {
        List<Paymentac> GetAllPayment();
        Paymentac GetPaymentbypatid(int id);
        void CreatePayment(Paymentac paymentac);
        void UpdatePayment(Paymentac paymentac);
        void DeletePayment(int id);
        List<Report> Reports();
    }
}
