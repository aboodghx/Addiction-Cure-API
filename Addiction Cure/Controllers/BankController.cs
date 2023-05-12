using Addiction_Cure.core.Data;
using Addiction_Cure.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService bankService;
        public BankController(IBankService bankService)
        {
            this.bankService = bankService;
        }
        [HttpGet]
        [Route("getallBank")]
        public List<Bankac> GetAllbank()
        {
            return bankService.GetAllBank();
        }

        [HttpPost]
        [Route("createBank")]
        public void createBank(Bankac bankac)
        {
            bankService.createBank(bankac);
        }

        [HttpPut]
        [Route("updateBank")]
        public void updateBank(Bankac bankac)
        {
            bankService.updateBank(bankac);
        }

        [HttpPost]
        [Route("deletebank/{aid}")]
        public void DeleteBank(int aid)
        {
            bankService.DeleteBank(aid);
        }
    }
}
