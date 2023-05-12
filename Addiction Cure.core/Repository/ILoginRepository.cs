using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Repository
{
    public interface ILoginRepository
    {
        bool register(Register patient);
        Loginac login(Loginac login);

        bool DoctorRegister(DoctorRegister doctorRegister);
        Dictorac DoctorId(string id);
        public Patientac patientid(string id);

    }
}
