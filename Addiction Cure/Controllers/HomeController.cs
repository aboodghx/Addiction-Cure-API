using Addiction_Cure.core.Data;
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
    public class HomeController : ControllerBase
    {
        private readonly IHomeService homeService;
        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }
        [HttpGet]
        [Route("getallHome")]
        public Homepageac GetAllHome()
        {
            return homeService.GetAllhome();
        }

        [HttpPost]
        [Route("createHome")]
        public void createhome(Homepageac homepageac)
        {
            homeService.createhome(homepageac);
        }

        [HttpPut]
        [Route("updateHome")]
        public void updatehome(Homepageac homepageac)
        {
            homeService.updatehome(homepageac);
        }

        [HttpPost]
        [Route("deleteHome/{id}")]
        public void DeleteHome(int id)
        {
            homeService.Deletehome(id);
        }

        [HttpPost]
        [Route("uploadImage")]
        public Homepageac UploadIMage()
        {
            var file = Request.Form.Files[0]; // 0 means the first image in postman  FORM DATA
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName; // INCYPTION OF THE IMAGE
            var fullPath = Path.Combine("C:\\Users\\Msi1\\Desktop\\Addiction-Cure-Angular\\src\\assets\\images", fileName); // GET THE IMAGE AND ADD IT TO IMAGES FILE IN OUR PROJECT


            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            // its like insert TEMPORARY record  from category all OF ITS  ATTRIBUTS  are null except the image //// NOT IN DATABASE ITS JUST TEMPORRARY

            Homepageac item = new Homepageac();
            item.Image1 = fileName;
            return item;
        }

        [HttpGet]
        [Route("GetHomeById/{id}")]
        public Homepageac GetHomeById(int id)
        {
            return homeService.GetHomeById(id);
        }
    }
}

