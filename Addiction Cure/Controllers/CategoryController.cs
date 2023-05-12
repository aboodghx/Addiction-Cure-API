using Addiction_Cure.core.Data;
using Addiction_Cure.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;

namespace Addiction_Cure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {


        private readonly ICategoryService _categoryService;





        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }



        [HttpGet]
        [Route("GetCategory")]
        public List<Categoryac> GetAllCategoryAC()
        {
            return _categoryService.GetAllCategoryAC();
        }



        [HttpGet]
        [Route("GetById/{id}")]
        public Categoryac GetCategoryByIdAC(int id)
        {
            return _categoryService.GetCategoryByIdAC(id);
        }


        [HttpPost]
        [Route("Create")]
        public void CreateCategoryAC([FromBody]Categoryac categoryac)
        {
            _categoryService.CreateCategoryAC(categoryac);
        }




        [HttpPut]
        [Route("Update")]
        public void UpdateCategoryAC([FromBody]Categoryac categoryac)
        {
            _categoryService.UpdateCategoryAC(categoryac);
        }





        [HttpDelete]
        [Route("DeleteById/{id}")]
        public void  DeleteCategoryAC(int id) 
        { 
          _categoryService.DeleteCategoryAC(id);
        
        }




        [HttpPost]
        [Route("uploadImage")]
        public Categoryac UploadIMage()
        {
            var file = Request.Form.Files[0]; // 0 means the first image in postman  FORM DATA
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName; // INCYPTION OF THE IMAGE
            var fullPath = Path.Combine("C:\\Users\\Msi1\\Desktop\\Addiction-Cure-Angular\\src\\assets\\images", fileName); // GET THE IMAGE AND ADD IT TO IMAGES FILE IN OUR PROJECT


            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            // its like insert TEMPORARY record  from category all OF ITS  ATTRIBUTS  are null except the image //// NOT IN DATABASE ITS JUST TEMPORRARY

            Categoryac item = new Categoryac();
            item.Image = fileName;
            return item;
        }


    }
}
