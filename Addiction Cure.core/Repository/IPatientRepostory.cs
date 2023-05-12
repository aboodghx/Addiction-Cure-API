using Addiction_Cure.core.Common;
using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Addiction_Cure.core.Repository
{
    public interface IPatientRepostory
    {
        List<Patientac> GetAllPatient();
        void createpatient(Patientac patient);
        void Delete(int patientid);
        void updatepatient(Register patient);
        patBy getbyid(int id);

        List<patBy> getbydoctorid(int id);
        void UpdateLevel(int id, string level);

        patBy getbyloginid(string id);




    }
}
