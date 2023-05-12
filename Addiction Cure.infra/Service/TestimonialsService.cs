using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class TestimonialsService : ITestimonialsService
    {

        private readonly ITestimonialsRepository _testimonialsRepository;


        // constructor with dependency injection from ICategoryRepository
        public TestimonialsService(ITestimonialsRepository testimonialsRepository)
        {
            _testimonialsRepository = testimonialsRepository;
        }






        // IMPLEMENTAION OF  GetAllTestimonialAC


        public List<Testimonial> GetAllTestimonialAC()
        {
            return _testimonialsRepository.GetAllTestimonialAC();
        }





        // IMPLEMENTAION OF  GetTestimonialByIdAC


        public Testemonialac GetTestimonialByIdAC(int id)
        {
            return _testimonialsRepository.GetTestimonialByIdAC(id);
        }







        // IMPLEMENTAION OF  CreateTestimonialAC


        public void CreateTestimonialAC(Testemonialac testemonialac)
        {
            _testimonialsRepository.CreateTestimonialAC(testemonialac);
        }







        // IMPLEMENTAION OF  UpdateTestimonialAC


        public void UpdateTestimonialAC(Testemonialac testemonialac)
        {
            _testimonialsRepository.UpdateTestimonialAC(testemonialac);
        }







        // IMPLEMENTAION OF  DeleteTestimonialAC


        public void DeleteTestimonialAC(int id)
        {
            _testimonialsRepository.DeleteTestimonialAC(id);
        }

        public void publish(int id)
        {
            _testimonialsRepository.publish(id);
        }

        public void unpublish(int id)
        {
            _testimonialsRepository.unpublish(id);
        }
    }
}
