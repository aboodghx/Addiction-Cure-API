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
    public class ContactUsRepository: IContactUsRepository
    {
        // Inject        
        private readonly IDBContext dBContext;
        public ContactUsRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<Contactusac> GetAllContactus()
        {
            IEnumerable<Contactusac> result = dBContext.Connection.Query<Contactusac>("CONTACTUSAC_PACKAGE.GetCONTACTUSAC",
                commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void createContactus(Contactusac contactusac)
        {
            var p = new DynamicParameters();
            p.Add("NAME1", contactusac.Name, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PHONES", contactusac.Phone, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("EMAILS", contactusac.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("SUBJECTS", contactusac.Subject, dbType: DbType.String, ParameterDirection.Input);
            p.Add("MESGS", contactusac.Mesg, dbType: DbType.String, ParameterDirection.Input);
            var result = dBContext.Connection.Execute("CONTACTUSAC_PACKAGE.CreateCONTACTUSAC",
                p, commandType: CommandType.StoredProcedure);
        }
        public void updateContactus(Contactusac contactusac)
        {
            var p = new DynamicParameters();
            p.Add("ContactUsID", contactusac.Contactid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("NAME1", contactusac.Name, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PHONES", contactusac.Phone, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("EMAILS", contactusac.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("SUBJECTS", contactusac.Subject, dbType: DbType.String, ParameterDirection.Input);
            p.Add("MESGS", contactusac.Mesg, dbType: DbType.String, ParameterDirection.Input);
            var result = dBContext.Connection.Execute("CONTACTUSAC_PACKAGE.UpdateCONTACTUSAC",
                p, commandType: CommandType.StoredProcedure);
        }
        public void DeleteContactus(int contactusid)
        {
            var p = new DynamicParameters();
            p.Add("ContactUsID", contactusid, dbType: DbType.Int32, ParameterDirection.Input);
            var result = dBContext.Connection.Execute("CONTACTUSAC_PACKAGE.DELETECONTACTUSAC",
                p, commandType: CommandType.StoredProcedure);
        }
    }
}
