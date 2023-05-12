using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Service;
using Addiction_Cure.infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using SixLabors.ImageSharp;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;
        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Loginac login)
        {
            var token = loginService.Login(login);
            if (token == null)
                return Unauthorized();
            else
                return Ok(token);
        }

        [HttpPost]
        [Route("register")]
        public bool register(Register patient)
        {
            try
            {
                loginService.register(patient);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        [HttpPost]
        [Route("uploadImage")]
        public Register UploadIMage()
        {
            var file = Request.Form.Files[0]; // 0 means the first image in postman  FORM DATA
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName; // INCYPTION OF THE IMAGE
            var fullPath = Path.Combine("C:\\Users\\User\\Addiction-Cure-Angular\\src\\assets\\images", fileName); // GET THE IMAGE AND ADD IT TO IMAGES FILE IN OUR PROJECT


            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Register item = new Register();
            item.Imagename = fileName;
            return item;
        }


        [HttpPost]
        [Route("DoctorRegister")]

        public bool DoctorRegister(DoctorRegister doctorRegister)
        {
            try
            {
                loginService.DoctorRegister(doctorRegister);
                return true;
            }
            catch
            {
                return false;
            }
        }


        [HttpPost]
        [Route("uploadImageDoctor")]
        public DoctorRegister UploadImages()
        {
            var file = Request.Form.Files[0]; // 0 means the first image in postman  FORM DATA
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName; // INCYPTION OF THE IMAGE
            var fullPath = Path.Combine("C:\\Users\\zex0\\Addiction-Cure-Angular\\src\\assets\\images", fileName); // GET THE IMAGE AND ADD IT TO IMAGES FILE IN OUR PROJECT


            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            // its like insert TEMPORARY record  from category all OF ITS  ATTRIBUTS  are null except the image //// NOT IN DATABASE ITS JUST TEMPORRARY

            DoctorRegister item = new DoctorRegister();
            item.Imagename = fileName;
            return item;
        }

        [HttpGet]
        [Route("doctorid/{id}")]
        public Dictorac DoctorId(string id)
        {
            return loginService.DoctorId(id);
        }
        
        [HttpGet]
        [Route("patientid/{id}")]
        public Patientac patientid(string id)
        {
            return loginService.patientid(id);
        }

    }
}
