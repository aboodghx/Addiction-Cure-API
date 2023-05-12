using Addiction_Cure.core.Common;
using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;


        // constructor with dependency injection from ICategoryRepository
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        // IMPLEMENTAION OF  GetAllCategoryAC

        public List<Categoryac> GetAllCategoryAC()
        {
           return _categoryRepository.GetAllCategoryAC();
        }




        // IMPLEMENTAION OF  GetCategoryByIdAC

        public Categoryac GetCategoryByIdAC(int id)
        {
            return _categoryRepository.GetCategoryByIdAC(id);


        }




        // IMPLEMENTAION OF  CreateCategoryAC

        public void CreateCategoryAC(Categoryac categoryac)
        {
            _categoryRepository.CreateCategoryAC(categoryac);

        }




        // IMPLEMENTAION OF  UpdateCategoryAC

        public void UpdateCategoryAC(Categoryac categoryac)
        {
            _categoryRepository.UpdateCategoryAC(categoryac);
        }






        // IMPLEMENTAION OF  DeleteCategoryAC

        public void DeleteCategoryAC(int id)
        {
            
            _categoryRepository.DeleteCategoryAC(id);


        }
    }
}
