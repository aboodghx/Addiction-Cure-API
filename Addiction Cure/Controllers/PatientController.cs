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
    public class PatientController : ControllerBase
    {
        private readonly IPatientService ipatientService;
        public PatientController(IPatientService ipatientService)
        {
            this.ipatientService = ipatientService;
        }

        [HttpGet]
        [Route("getallPatient")]
        public List<Patientac> GetAllPatient()
        {
            return ipatientService.GetAllPatient();
        }

        [HttpPost]
        [Route("createPatient")]
        public void createpatient(Patientac patient)
        {
            ipatientService.createpatient(patient);
        }

        [HttpPut]
        [Route("updatePatient")]
        public void updatepatient(Register patient)
        {
            ipatientService.updatepatient(patient);
        }

        [HttpDelete]
        [Route("deletePatient/{patientid}")]
        public void Delete(int patientid)
        {
            ipatientService.Delete(patientid);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public patBy getbyid(int id)
        {
            return ipatientService.getbyid(id);
        }

        [HttpGet]
        [Route("getbydoctorid/{id}")]
        public List<patBy> getbydoctorid(int id)
        {
            return ipatientService.getbydoctorid(id);
        }


        [HttpGet]
        [Route("Level/{id}/{level}")]
        public void UpdateLevel(int id, string level)
        {
            ipatientService.UpdateLevel(id , level);
        }

        [HttpGet]
        [Route("loginid/{id}")]

        public patBy getbyloginid(string id)
        {
           return ipatientService.getbyloginid(id);
        }

    }
}
