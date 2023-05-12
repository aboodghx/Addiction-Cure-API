using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Dapper;
using Addiction_Cure.core.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Addiction_Cure.infra.Repository
{
    public class HomeRepository : IHomeRepository
    {
        // Inject        
        private readonly IDBContext dBContext;
        public HomeRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public Homepageac GetAllhome()
        {
            IEnumerable<Homepageac> result = dBContext.Connection.Query<Homepageac>("HOMEPAGEAC_PACKAGE.GetAllHOMEPAGEAC",
                commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
        public void createhome(Homepageac homepageac)
        {
            var p = new DynamicParameters();
            p.Add("IMAGE1S", homepageac.Image1, dbType: DbType.String, ParameterDirection.Input);
            p.Add("IMAGE2S", homepageac.Image2, dbType: DbType.String, ParameterDirection.Input);
            p.Add("LOGOS", homepageac.Logo, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PARAGRAPHS", homepageac.Paragraph, dbType: DbType.String, ParameterDirection.Input);
            p.Add("EMAILS", homepageac.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PHONES", homepageac.Phone, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("ADDRESSS", homepageac.Address, dbType: DbType.String, ParameterDirection.Input);
            p.Add("TEXT1S", homepageac.Text1, dbType: DbType.String, ParameterDirection.Input);

            var result = dBContext.Connection.Execute("HOMEPAGEAC_PACKAGE.CreateHOMEPAGEAC",
                p, commandType: CommandType.StoredProcedure);
        }
        public void updatehome(Homepageac homepageac)
        {
            var p = new DynamicParameters();
            p.Add("HOMEIDS", homepageac.Homeid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("IMAGE1S", homepageac.Image1, dbType: DbType.String, ParameterDirection.Input);
            p.Add("IMAGE2S", homepageac.Image2, dbType: DbType.String, ParameterDirection.Input);
            p.Add("LOGOS", homepageac.Logo, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PARAGRAPHS", homepageac.Paragraph, dbType: DbType.String, ParameterDirection.Input);
            p.Add("EMAILS", homepageac.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PHONES", homepageac.Phone, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("ADDRESSS", homepageac.Address, dbType: DbType.String, ParameterDirection.Input);
            p.Add("TEXT1S", homepageac.Text1, dbType: DbType.String, ParameterDirection.Input);

            var result = dBContext.Connection.Execute("HOMEPAGEAC_PACKAGE.UpdateHOMEPAGEAC",
                p, commandType: CommandType.StoredProcedure);
        }
        public void Deletehome(int id)
        {
            var p = new DynamicParameters();
            p.Add("HOMEIDS", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = dBContext.Connection.Execute("HOMEPAGEAC_PACKAGE.DELETEHOMEPAGEAC",
                p, commandType: CommandType.StoredProcedure);
        }

        public Homepageac GetHomeById(int id)
        {
            var p = new DynamicParameters();
            p.Add("HOMEIDS",id,dbType:DbType.Int32, ParameterDirection.Input);
            IEnumerable<Homepageac> result = dBContext.Connection.Query<Homepageac>("HOMEPAGEAC_PACKAGE.GetByIDHOMEPAGEAC",p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
