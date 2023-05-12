using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using Addiction_Cure.infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class TestService : ITestService
    {
        private readonly ITestRepository testRepository;
        public TestService(ITestRepository testRepository)
        {
            this.testRepository = testRepository;
        }



      public  List<Testac> GetAllTest()
        {
            return testRepository.GetAllTest();
        }
       public void CreateTest(Testac test)
        {
            testRepository.CreateTest(test);
        }
       public void UpdateTest(Testac test)
        {
            testRepository.UpdateTest(test);
        }
        public void DeleteTest(int id)
        {
            testRepository.DeleteTest(id);
        }

        public List<TestWithquas> GetByPatId(int id)
        {
           return testRepository.GetByPatId(id);
        }

        public void updateStatus(int id, int status)
        {
            testRepository.updateStatus(id, status);    
        }

        public List<TestWithquas> Getanswer(int id, int testnumber)
        {
            return testRepository.Getanswer(id, testnumber);    
        }
    }
}
