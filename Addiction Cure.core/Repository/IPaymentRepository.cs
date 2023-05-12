using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Repository
{
    public interface IPaymentRepository
    {
        List<Paymentac> GetAllPayment();
        void CreatePayment(Paymentac paymentac);

        Paymentac GetPaymentbypatid(int id);
        void UpdatePayment(Paymentac paymentac);
        void DeletePayment(int id);
        List<Report> Reports();
    }
}
