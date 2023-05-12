using Addiction_Cure.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Service
{
    public interface IHomeService
    {
        Homepageac GetAllhome();
        void createhome(Homepageac homepageac);
        void updatehome(Homepageac homepageac);
        void Deletehome(int id);
        Homepageac GetHomeById(int id);
    }
}
