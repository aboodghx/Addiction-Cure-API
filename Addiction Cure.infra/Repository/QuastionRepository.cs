using Addiction_Cure.core.Common;
using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Addiction_Cure.infra.Repository
{
    public class QuastionRepository : IQuastionRepository
    {
        private readonly IDBContext dbContext;
        public QuastionRepository(IDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Quastionsac> GetAllQuastions(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int64, ParameterDirection.Input);
            IEnumerable<Quastionsac> result = dbContext.Connection.Query<Quastionsac>("QUASTION_package.getAllQUASTION",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void CreateQuastion(Quastionsac quastionsac)
        {
            var p = new DynamicParameters();
            p.Add("quastionAC", quastionsac.Quastion, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CategoryIDAC", quastionsac.Categoryid, dbType: DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("QUASTION_package.CreateQUASTION", p, commandType: CommandType.StoredProcedure);
        }
        public void UpdateQuastion(Quastionsac quastionsac)
        {
            var p = new DynamicParameters();
            p.Add("quastionIDAC", quastionsac.Quastionid, dbType: DbType.Int64, ParameterDirection.Input);
            p.Add("quastionAC", quastionsac.Quastion, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CategoryIDAC", quastionsac.Categoryid, dbType: DbType.Int64, ParameterDirection.Input);
            dbContext.Connection.Execute("QUASTION_package.UpdateQUASTION", p, commandType: CommandType.StoredProcedure);
        }
        public void DeleteQuastion(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int64, ParameterDirection.Input);
            dbContext.Connection.Execute("QUASTION_package.DeleteQUASTION", p, commandType: CommandType.StoredProcedure);
        }

        public List<Quastionsac> GetQuastionsById(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int64, ParameterDirection.Input);
            IEnumerable<Quastionsac> result = dbContext.Connection.Query<Quastionsac>("QUASTION_package.GetQUASTIONBYID",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public  List<quasWithcat> GetAllQuestionss()
        {

            IEnumerable<quasWithcat> result = dbContext.Connection.Query<quasWithcat>("QUASTION_package.GetAllQuestionss",
                commandType: CommandType.StoredProcedure);
            return result.ToList();


        }

       
    }
}