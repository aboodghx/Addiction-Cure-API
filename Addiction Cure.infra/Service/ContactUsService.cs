using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository contactUsRepository;
        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            this.contactUsRepository = contactUsRepository;
        }
        public List<Contactusac> GetAllContactus()
        {
            return contactUsRepository.GetAllContactus();
        }

        public void createContactus(Contactusac contactusac)
        {
            contactUsRepository.createContactus(contactusac);
        }
        public void updateContactus(Contactusac contactusac)
        {
            contactUsRepository.updateContactus(contactusac);
        }
        public void DeleteContactus(int contactusid)
        {
            contactUsRepository.DeleteContactus(contactusid);
        }
    }
}
