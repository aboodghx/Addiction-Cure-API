using Addiction_Cure.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Service
{
    public interface IBankService
    {
        List<Bankac> GetAllBank();
        void createBank(Bankac bankac);
        void updateBank(Bankac bankac);
        void DeleteBank(int aID);
    }
}
