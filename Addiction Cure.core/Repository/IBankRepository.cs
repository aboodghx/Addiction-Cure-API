using Addiction_Cure.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Repository
{
    public interface IBankRepository
    {
        //void DeleteBank(int aID);

        List<Bankac> GetAllBank();
        void createBank(Bankac bankac);
        void updateBank(Bankac bankac);
        void DeleteBank(int aID);
    }
}
