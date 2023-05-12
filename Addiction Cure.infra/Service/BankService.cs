using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class BankService : IBankService
    {
        private readonly IBankRepository bankRepository;
        public BankService(IBankRepository bankRepository)
        {
            this.bankRepository = bankRepository;
        }
        public List<Bankac> GetAllBank()
        {
            return bankRepository.GetAllBank();
        }

        public void createBank(Bankac bankac)
        {
            bankRepository.createBank(bankac);
        }
        public void updateBank(Bankac bankac)
        {
            bankRepository.updateBank(bankac);
        }
        public void DeleteBank(int aID)
        {
            bankRepository.DeleteBank(aID);
        }
    }
}
