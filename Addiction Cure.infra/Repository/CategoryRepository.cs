using Addiction_Cure.core.Common;
using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Addiction_Cure.infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {


        private readonly IDBContext _DbContext;



        // constructor with dependency injection from domain entity layer
        public CategoryRepository(IDBContext DbContext)
        {
            _DbContext = DbContext;
        }




        // IMPLEMENTAION OF  GetAllCategoryAC

        public List<Categoryac> GetAllCategoryAC()
        {
            IEnumerable<Categoryac> result = _DbContext.Connection.Query<Categoryac>("CATEGORYAC_PACKAGE.GetAllCategoryAC",
                commandType:CommandType.StoredProcedure);

            return result.ToList();
        }




        // IMPLEMENTAION OF  GetCategoryByIdAC

        public Categoryac GetCategoryByIdAC(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID",id,dbType:DbType.Int32,direction:ParameterDirection.Input);

            IEnumerable<Categoryac> result = _DbContext.Connection.Query<Categoryac>("CATEGORYAC_PACKAGE.GetCategoryByIdAC",p,
                            commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();

        }




        // IMPLEMENTAION OF  CreateCategoryAC

        public void CreateCategoryAC(Categoryac categoryac)
        {
            var p = new DynamicParameters();

            p.Add("CATEGORYNAMEAC",categoryac.Categoryname,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("IMAGEAC", categoryac.Image,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("ABOUTTEXTAC", categoryac.Abouttext,dbType:DbType.String,direction:ParameterDirection.Input);

            // you can remove the var result its ok if you dont want to know number of rows affected 
            var result = _DbContext.Connection.Execute("CATEGORYAC_PACKAGE.CreateCategoryAC", p,
                            commandType: CommandType.StoredProcedure);

        }




        // IMPLEMENTAION OF  UpdateCategoryAC

        public void UpdateCategoryAC(Categoryac categoryac)
        {
            var p = new DynamicParameters();
            p.Add("ID", categoryac.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CATEGORYNAMEAC", categoryac.Categoryname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGEAC", categoryac.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ABOUTTEXTAC", categoryac.Abouttext, dbType: DbType.String, direction: ParameterDirection.Input);

            // you can remove the var result its ok if you dont want to know number of rows affected 
            var result = _DbContext.Connection.Execute("CATEGORYAC_PACKAGE.UpdateCategoryAC", p,
                            commandType: CommandType.StoredProcedure);
        }






        // IMPLEMENTAION OF  DeleteCategoryAC

        public void DeleteCategoryAC(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID",id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            _DbContext.Connection.Execute("CATEGORYAC_PACKAGE.DeleteCategoryAC", p,
                commandType: CommandType.StoredProcedure);



        }

    }
}
