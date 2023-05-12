using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Service
{
    public interface ILoginService
    {
        String Login(Loginac login);
        bool register(Register patient);
        bool DoctorRegister(DoctorRegister doctorRegister);
        Dictorac DoctorId(string id);
        public Patientac patientid(string id);
    }
}
