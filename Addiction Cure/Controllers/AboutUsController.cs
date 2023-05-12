using Addiction_Cure.core.Data;
using Addiction_Cure.core.Service;
using Addiction_Cure.infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService aboutUsService;
        public AboutUsController(IAboutUsService aboutUsService)
        {
            this.aboutUsService = aboutUsService;
        }
        [HttpGet]
        [Route("getallAboutUs")]
        public Aboutusac GetAllAboutUs()
        {
           
            return aboutUsService.GetAllAboutUs();
        }


        [HttpGet]
        [Route("getAboutUsById/{id}")]
        public  Aboutusac GetAboutusByid(int id)
        {
            return aboutUsService.GetAboutusByid(id);
        }




        [HttpPost]
        [Route("createAboutUs")]
        public void createAboutUs(Aboutusac aboutusac)
        {
            aboutUsService.createAboutUs(aboutusac);
        }

        [HttpPut]
        [Route("updateAboutUs")]
        public void updateAboutUs(Aboutusac aboutusac)
        {
            aboutUsService.updateAboutUs(aboutusac);
        }

        [HttpDelete]
        [Route("deleteAboutUs/{Aboutusid}")]
        public void DeleteAboutUs(int aboutusid)
        {
            aboutUsService.DeleteAboutUs(aboutusid);
        }


        [HttpPost]
        [Route("uploadImage")]
        public Aboutusac UploadIMage()
        {
            var file = Request.Form.Files[0]; // 0 means the first image in postman  FORM DATA
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName; // INCYPTION OF THE IMAGE
            var fullPath = Path.Combine("C:\\Users\\User\\Addiction-Cure-Angular\\src\\assets\\images", fileName); // GET THE IMAGE AND ADD IT TO IMAGES FILE IN OUR PROJECT


            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            // its like insert TEMPORARY record  from category all OF ITS  ATTRIBUTS  are null except the image //// NOT IN DATABASE ITS JUST TEMPORRARY

            Aboutusac item = new Aboutusac();
            item.Image = fileName;
            return item;
        }
    }
}
