using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Service
{
    public interface IDoctorService
    {
        List<Dictorac> GetAlldoctor();
        void createdoctor(DoctorRegister doctor);
        void updatedoctor(DoctorRegister doctor);
        void Deletedoctor(int doctorid);
        List<SearchByName> GetDocByName(string thename);
        docBy getbyid(int id);

        docBy GetByLoginId(string id);

    }
}
