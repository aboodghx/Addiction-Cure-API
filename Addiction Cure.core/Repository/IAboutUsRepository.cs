using Addiction_Cure.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Repository
{
    public interface IAboutUsRepository
    {
        Aboutusac GetAllAboutUs();
        void createAboutUs(Aboutusac aboutusac);
        void updateAboutUs(Aboutusac aboutusac);
        void DeleteAboutUs(int aboutusid);

        Aboutusac GetAboutusByid(int id);
    }
}
