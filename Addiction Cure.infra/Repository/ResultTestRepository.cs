using Addiction_Cure.core.Common;
using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Dapper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Addiction_Cure.core.DTO;

namespace Addiction_Cure.infra.Repository
{
    public class ResultTestRepository :IResultTestRepository
    {
        private readonly IDBContext dbContext;
        public ResultTestRepository(IDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

      public List<ResultTestDto> GetAllResult()
        {
            IEnumerable<ResultTestDto> result = dbContext.Connection.Query<ResultTestDto>("ResultTest_pack.GetAllResultac", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
     public void CreateResult(Resulttsetac resulttsetac)
        {
            var p = new  DynamicParameters();
            p.Add("resulttestac", resulttsetac.Resulttest,dbType:DbType.String,ParameterDirection.Input);
            p.Add("descrpionAc", resulttsetac.Description, dbType: DbType.String, ParameterDirection.Input);
            p.Add("periodDateac", resulttsetac.Perioddate, dbType: DbType.String, ParameterDirection.Input);
            p.Add("numberOfTestac", resulttsetac.Numberoftest, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("DateTestAc", resulttsetac.Datetest, dbType: DbType.Date, ParameterDirection.Input);
            p.Add("patientidac", resulttsetac.Patientid, dbType: DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("ResultTest_pack.CreateResultac",p,commandType:CommandType.StoredProcedure);
        }
     public void UpdateResult(Resulttsetac resulttsetac)
        {

            var p = new DynamicParameters();
            p.Add("resultAcId", resulttsetac.Resulttestid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("patientidac", resulttsetac.Patientid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("resulttestac", resulttsetac.Resulttest, dbType: DbType.String, ParameterDirection.Input);
            p.Add("descrpionAc", resulttsetac.Description, dbType: DbType.String, ParameterDirection.Input);
            p.Add("periodDateac", resulttsetac.Perioddate, dbType: DbType.String, ParameterDirection.Input);
            p.Add("numberOfTestac", resulttsetac.Numberoftest, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("DateTestAc", resulttsetac.Datetest, dbType: DbType.Date, ParameterDirection.Input);
            dbContext.Connection.Execute("ResultTest_pack.UpdateResultac", p, commandType: CommandType.StoredProcedure);

        }
     public void DeleteResult(int id)
        {
            var p = new DynamicParameters();
            p.Add("resultAcId", id, dbType: DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("ResultTest_pack.DeleteResultac", p, commandType: CommandType.StoredProcedure);

        }
        public List<Report> GetResultBetween(DateTime datefrom, DateTime dateto)
        {
            var p = new DynamicParameters();
            p.Add("datetestac1", datefrom, dbType: DbType.Date, ParameterDirection.Input);
            p.Add("datetestAc2", dateto, dbType: DbType.Date, ParameterDirection.Input);
            IEnumerable<Report> result = dbContext.Connection.Query<Report>("ResultTest_pack.testbydate", p,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public Resulttsetac Getbyid(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            var x = dbContext.Connection.Query<Resulttsetac>("ResultTest_pack.Getbyid", p, commandType: CommandType.StoredProcedure);
            return x.FirstOrDefault();
        }


       public List<ResultTestDto> GetByDocid(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<ResultTestDto> result = dbContext.Connection.Query<ResultTestDto>("ResultTest_pack.GetbyDocid",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
       public List<ResultTestDto> GetBypatid(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<ResultTestDto> result = dbContext.Connection.Query<ResultTestDto>("ResultTest_pack.GetbyPatid",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public void afterquiz(int id, string result)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("resulttestac", result, dbType: DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("ResultTest_pack.Afterquiz", p, commandType: CommandType.StoredProcedure);
        }
    }
}
