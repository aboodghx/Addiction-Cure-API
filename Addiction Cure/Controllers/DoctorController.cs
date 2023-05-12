using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService idoctorService;
        public DoctorController(IDoctorService idoctorService)
        {
            this.idoctorService = idoctorService;
        }

        [HttpGet]
        [Route("getalldoctor")]
        public List<Dictorac> GetAlldoctor()
        {
            return idoctorService.GetAlldoctor();
        }

        [HttpPost]
        [Route("createdoctor")]
        public void createdoctor(DoctorRegister doctor)
        {
            idoctorService.createdoctor(doctor);
        }

        [HttpPut]
        [Route("updatedoctor")]
        public void updatedoctor(DoctorRegister doctor)
        {
            idoctorService.updatedoctor(doctor);
        }

        [HttpDelete]
        [Route("deletedoctor/{doctorid}")]
        public void Deletedoctor(int doctorid)
        {
            idoctorService.Deletedoctor(doctorid);
        }
        [HttpGet]
        [Route("SearchByName/{thename}")]
        public List<SearchByName> GetDocByName(string thename)
        {
         return  idoctorService.GetDocByName(thename);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public docBy getbyid(int id)
        {
            return idoctorService.getbyid(id);
        }

        [HttpGet]
        [Route("getbyLoginID/{id}")]
        public docBy GetByLoginId(string id)
        {
            return idoctorService.GetByLoginId(id);
        }




        [HttpPost]
        [Route("uploadImage")]
        public Dictorac UploadIMage()
        {
            var file = Request.Form.Files[0]; // 0 means the first image in postman  FORM DATA
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName; // INCYPTION OF THE IMAGE
            var fullPath = Path.Combine("C:\\Users\\Msi1\\Desktop\\Addiction-Cure-Angular\\src\\assets\\images", fileName); // GET THE IMAGE AND ADD IT TO IMAGES FILE IN OUR PROJECT


            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            // its like insert TEMPORARY record  from category all OF ITS  ATTRIBUTS  are null except the image //// NOT IN DATABASE ITS JUST TEMPORRARY

            Dictorac item = new Dictorac();
            item.Imagename = fileName;
            return item;
        }
    }
}
