using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.DTO
{
    public class PaymentRequest
    {
        public string cardNumber { get; set; }
        public string cvc { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Email { get; set; }
        public string Currency { get; set; }
        public string Level { get; set; }
        public string CategoryName { get; set; }

    }
}
