using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Service;
using Addiction_Cure.infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuastionController : ControllerBase
    {
        private readonly IQuastionService quastionService;
        public QuastionController(IQuastionService quastionService)
        {
            this.quastionService = quastionService;
        }

        [HttpGet]
        [Route("GetQuastions/{id}")]
        public List<Quastionsac> GetAllQuastions(int id)
        {
            return quastionService.GetAllQuastions(id);
        }

        [HttpPost]

        public void CreateQuastion(Quastionsac quastionsac)
        {
            quastionService.CreateQuastion(quastionsac);
        }

        [HttpPut]
        public void UpdateQuastion(Quastionsac quastionsac)
        {
            quastionService.UpdateQuastion(quastionsac);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteQuastion(int id)
        {
            quastionService.DeleteQuastion(id);
        }

        [HttpGet]
        [Route("GetQUASTIONBYID/{id}")]
       public List<Quastionsac> GetQuastionsById(int id)
        {
            return quastionService.GetQuastionsById(id);
        }


        [HttpGet]
        [Route("GetAllQuestionss")]
        public List<quasWithcat> GetAllQuastionss()
        {
            return quastionService.GetAllQuestionss();
        }
    }
}
