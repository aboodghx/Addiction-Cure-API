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
    public class BankRepository: IBankRepository
    {
        // Inject        
        private readonly IDBContext dBContext;
        public BankRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<Bankac> GetAllBank()
        {
            IEnumerable<Bankac> result = dBContext.Connection.Query<Bankac>("BANKAC_PACKAGE.GetAllBANKAC",
                commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void createBank(Bankac bankac)
        {
            var p = new DynamicParameters();
            p.Add("NAME1", bankac.Name, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CARDNUMPERS", bankac.Cardnumper, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CVVS", bankac.Cvv, dbType: DbType.String, ParameterDirection.Input);
            p.Add("AMOUNTS", bankac.Amount, dbType: DbType.String, ParameterDirection.Input);
            
            var result = dBContext.Connection.Execute("BANKAC_PACKAGE.CreateBANKAC",
                p, commandType: CommandType.StoredProcedure);
        }
        public void updateBank(Bankac bankac)
        {

            var p = new DynamicParameters();
            p.Add("ID", bankac.Bankid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("NAME1", bankac.Name, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CARDNUMPERS", bankac.Cardnumper, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CVVS", bankac.Cvv, dbType: DbType.String, ParameterDirection.Input);
            p.Add("AMOUNTS", bankac.Amount, dbType: DbType.String, ParameterDirection.Input);

            var result = dBContext.Connection.Execute("BANKAC_PACKAGE.UpdateBANKAC",
                p, commandType: CommandType.StoredProcedure);
        }
        public void DeleteBank(int aID)
        {
            var p = new DynamicParameters();
            p.Add("ID", aID, dbType: DbType.Int32, ParameterDirection.Input);
            var result = dBContext.Connection.Execute("BANKAC_PACKAGE.DELETEBANKAC",
                p, commandType: CommandType.StoredProcedure);
        }
    }
}
