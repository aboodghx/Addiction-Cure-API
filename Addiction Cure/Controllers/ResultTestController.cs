using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultTestController : ControllerBase
    {
        private readonly IResultTestService resultTestService;

        public ResultTestController(IResultTestService resultTestService)
        {
            this.resultTestService = resultTestService;
        }


        [HttpGet]
        [Route("GetAllResult")]
        public List<ResultTestDto> GetAllResult()
        {
            return resultTestService.GetAllResult();
        }

        [HttpPost]
        public void CreateResult(Resulttsetac result)
        {
            resultTestService.CreateResult(result);
        }

        [HttpPut]
        public void UpdateResult(Resulttsetac result)
        { 
            resultTestService.UpdateResult(result);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteResult(int id ) {
        resultTestService.DeleteResult(id);
        }

        [HttpGet]
        [Route("{datefrom}/{dateto}")]
        public List<Report> GetResultBetween(DateTime datefrom, DateTime dateto)
        {
            return resultTestService.GetResultBetween(datefrom, dateto);
        }
        [HttpGet]
        [Route("byid/{id}")]
        public Resulttsetac Getbyid(int id)
        {
            return resultTestService.Getbyid(id);
        }

        [HttpGet]
        [Route("Bydocid/{id}")]
        public List<ResultTestDto> GetByDocid(int id)
        {
            return resultTestService.GetByDocid(id);
        }
        [HttpGet]
        [Route("ByPatid/{id}")]
        public List<ResultTestDto> GetBypatid(int id)
        {
            return resultTestService.GetBypatid(id);
        }

        [HttpGet]
        [Route("afterquiz/{id}/{result}")]
        public void afterquiz(int id, string result)
        {
            resultTestService.afterquiz(id, result);
        }
    }
}
