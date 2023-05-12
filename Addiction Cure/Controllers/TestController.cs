using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService testService;
        public TestController(ITestService testService)
        {
            this.testService = testService;
        }

        [HttpGet]
        public List<Testac> GetAllTest()
        {
            return testService.GetAllTest();
        }

        [HttpPost]

        public void CreateTest(Testac testac) {
            testService.CreateTest(testac);
        }

        [HttpPut]
        public void UpdateTest(Testac testac)
        {
            testService.UpdateTest(testac);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteTest(int id)
        {
            testService.DeleteTest(id);
        }
        [HttpGet]
        [Route("getByPatID/{id}")]
        public List<TestWithquas> GetByPatId(int id)
        {
          return  testService.GetByPatId(id);
        }

        [HttpGet]
        [Route("updateStatus/{id}/{status}")]
        public void updateStatus(int id, int status)
        {
            testService.updateStatus(id, status);   
        }

        [HttpGet]
        [Route("Getanswer/{id}/{testnumber}")]
        public List<TestWithquas> Getanswer(int id, int testnumber)
        {
            return testService.Getanswer(id, testnumber);   
        }

    }
}
