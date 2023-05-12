using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Service
{
    public interface ITestimonialsService
    {

        List<Testimonial> GetAllTestimonialAC();

        Testemonialac GetTestimonialByIdAC(int id);

        void CreateTestimonialAC(Testemonialac testemonialac);
        void UpdateTestimonialAC(Testemonialac testemonialac);

        void DeleteTestimonialAC(int id);
        void publish(int id);
        void unpublish(int id);

    }
}
