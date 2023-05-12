using Addiction_Cure.core.Data;
using Addiction_Cure.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService contactUsService;
        public ContactUsController(IContactUsService contactUsService)
        {
            this.contactUsService = contactUsService;
        }
        [HttpGet]
        [Route("getallContactUs")]
        public List<Contactusac> GetAllContactUs()
        {
            return contactUsService.GetAllContactus();
        }

        [HttpPost]
        [Route("createContactUs")]
        public void createContactUs(Contactusac contactusac)
        {
            contactUsService.createContactus(contactusac);
        }

        [HttpPut]
        [Route("updateContactUs")]
        public void updateContactUs(Contactusac contactusac)
        {
            contactUsService.updateContactus(contactusac);
        }

        [HttpDelete]
        [Route("deleteContactUs/{Contactusid}")]
        public void DeleteContactUs(int contactusid)
        {
            contactUsService.DeleteContactus(contactusid);
        }
    }
}
