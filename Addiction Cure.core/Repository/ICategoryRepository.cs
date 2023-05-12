using Addiction_Cure.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Repository
{
    public interface ICategoryRepository
    {

        List<Categoryac> GetAllCategoryAC();  
        
        Categoryac GetCategoryByIdAC(int id);

        void CreateCategoryAC(Categoryac categoryac);
        void UpdateCategoryAC(Categoryac categoryac);

        void DeleteCategoryAC(int id);


    }
}
