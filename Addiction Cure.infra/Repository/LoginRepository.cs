using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Dapper;
using Addiction_Cure.core.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Addiction_Cure.core.DTO;
using System.Numerics;

namespace Addiction_Cure.infra.Repository
{
    public class LoginRepository: ILoginRepository
    {
        // Inject        
        private readonly IDBContext dBContext;
        public LoginRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        //login
        public Loginac login(Loginac login)
        {
            var p = new DynamicParameters();
            p.Add("passwordac", login.Password, dbType: DbType.String, ParameterDirection.Input);
            p.Add("EMAILAC", login.Email, dbType: DbType.String, ParameterDirection.Input);
            IEnumerable<Loginac> result = dBContext.Connection.Query<Loginac>("LOGINAC_PACKAGE.LOGIN", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        //register
        public bool register(Register patient)
        {
            var p = new DynamicParameters();
            p.Add("USERNAMEAC", patient.Username, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PASSWORDAC", patient.Password, dbType: DbType.String, ParameterDirection.Input);
            p.Add("EMAILAC", patient.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("roleidac", patient.Roleid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("firstnameAc", patient.Firstname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("lastnameAc", patient.Lastname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("imagenameAc", patient.Imagename, dbType: DbType.String, ParameterDirection.Input);
            p.Add("levelAc", patient.Level1, dbType: DbType.String, ParameterDirection.Input);
            p.Add("doctodIdAc", patient.Doctodid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("CATEGORYIDAC", patient.Categoryid, dbType: DbType.Int32, ParameterDirection.Input);
            var result = dBContext.Connection.Execute("LOGINAC_PACKAGE.Registers", p, commandType: CommandType.StoredProcedure);
            return true;
        }







        //DoctorRegister
        public bool DoctorRegister(DoctorRegister doctorRegister)
        {
            var p = new DynamicParameters();
            p.Add("Email", doctorRegister.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("passwordac", doctorRegister.Password, dbType: DbType.String, ParameterDirection.Input);
            p.Add("username", doctorRegister.Username, dbType: DbType.String, ParameterDirection.Input);
            p.Add("roleid", doctorRegister.Roleid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("firstnameAc", doctorRegister.Firstname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("lastnameAc", doctorRegister.Lastname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("imagenameAc", doctorRegister.Imagename, dbType: DbType.String, ParameterDirection.Input);
            p.Add("levelAc", doctorRegister.Level1, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CATEGORYIDAC", doctorRegister.Categoryid, dbType: DbType.Int32, ParameterDirection.Input);
            dBContext.Connection.Execute("Doctor_package.CreateDoctor", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        //DoctorId
        public Patientac patientid(string id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.String, ParameterDirection.Input);

            IEnumerable<Patientac> result = dBContext.Connection.Query<Patientac>("LOGINAC_PACKAGE.patientid", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        //DoctorId
        public Dictorac DoctorId(string id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.String, ParameterDirection.Input);

            IEnumerable<Dictorac> result = dBContext.Connection.Query<Dictorac>("LOGINAC_PACKAGE.DoctorId", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
    }
}
