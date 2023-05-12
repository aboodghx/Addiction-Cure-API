using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUsRepository aboutUsRepository;
        public AboutUsService(IAboutUsRepository aboutUsRepository)
        {
            this.aboutUsRepository = aboutUsRepository;
        }
        public Aboutusac GetAllAboutUs()
        {
            return aboutUsRepository.GetAllAboutUs();
        }

        public void createAboutUs(Aboutusac aboutusac)
        {
            aboutUsRepository.createAboutUs(aboutusac);
        }
        public void updateAboutUs(Aboutusac aboutusac)
        {
            aboutUsRepository.updateAboutUs(aboutusac);
        }
        public void DeleteAboutUs(int aboutusid)
        {
            aboutUsRepository.DeleteAboutUs(aboutusid);
        }

        public Aboutusac GetAboutusByid(int id)
        {
            return aboutUsRepository.GetAboutusByid(id);
        }
    }
}
