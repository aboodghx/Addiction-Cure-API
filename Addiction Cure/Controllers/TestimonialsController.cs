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
    public class TestimonialsController : ControllerBase
    {

        private readonly ITestimonialsService _testimonialsService;





        public TestimonialsController(ITestimonialsService testimonialsService)
        {
            _testimonialsService = testimonialsService;
        }

        // IMPLEMENTAION OF  GetAllTestimonialAC




        [HttpGet]
        [Route("GetAllTestemonial")]
        public List<Testimonial> GetAllTestimonialAC()
        {
            return _testimonialsService.GetAllTestimonialAC();
        }





        // IMPLEMENTAION OF  GetTestimonialByIdAC

        [HttpGet]
        [Route("GetTestimonialByPatienId/{id}")]
        public Testemonialac GetTestimonialByIdAC(int id)
        {
            return _testimonialsService.GetTestimonialByIdAC(id);
        }







        // IMPLEMENTAION OF  CreateTestimonialAC

        [HttpPost]
        [Route("Create")]
        public void CreateTestimonialAC(Testemonialac testemonialac)
        {
            _testimonialsService.CreateTestimonialAC(testemonialac);
        }







        // IMPLEMENTAION OF  UpdateTestimonialAC

        [HttpPut]
        [Route("Update")]
        public void UpdateTestimonialAC(Testemonialac testemonialac)
        {
            _testimonialsService.UpdateTestimonialAC(testemonialac);
        }







        // IMPLEMENTAION OF  DeleteTestimonialAC

        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteTestimonialAC(int id)
        {
            _testimonialsService.DeleteTestimonialAC(id);
        }

        [HttpGet]
        [Route("publish/{id}")]
        public void publish(int id)
        {
            _testimonialsService.publish(id);
        }


        [HttpGet]
        [Route("unpublish/{id}")]
        public void unpublish(int id)
        {
            _testimonialsService.unpublish(id);
        }


    }
}
