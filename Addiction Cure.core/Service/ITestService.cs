using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Service
{
    public interface ITestService
    {
        List<Testac> GetAllTest();
        void CreateTest(Testac test);
        void UpdateTest(Testac test);
        void DeleteTest(int id);
        List<TestWithquas> Getanswer(int id, int testnumber);
        List<TestWithquas> GetByPatId(int id);

        void updateStatus(int id, int status);

    }
}
