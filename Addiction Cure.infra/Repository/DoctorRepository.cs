using Addiction_Cure.core.Data;
using Addiction_Cure.core.Repository;
using Dapper;
using Addiction_Cure.core.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Addiction_Cure.core.DTO;

namespace Addiction_Cure.infra.Repository
{
    public class DoctorRepository: IDoctorRepository
    {
        // Inject        
        private readonly IDBContext dBContext;
        public DoctorRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        //Get all doctor
        public List<Dictorac> GetAlldoctor()
        {
            IEnumerable<Dictorac> result = dBContext.Connection.Query<Dictorac>("Doctor_package.getAllDoctor", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        //Create doctor
        public void createdoctor(DoctorRegister doctor)
        {
            var p = new DynamicParameters();
            p.Add("firstnameAc", doctor.Firstname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("lastnameAc", doctor.Lastname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("imagenameAc", doctor.Imagename, dbType: DbType.String, ParameterDirection.Input);
            p.Add("levelAc", doctor.Level1, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CATEGORYIDAC", doctor.Categoryid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("loginidac", doctor.Loginid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("usernameac", doctor.Username, dbType: DbType.String, ParameterDirection.Input);
            p.Add("passwordac", doctor.Password, dbType: DbType.String, ParameterDirection.Input);
            p.Add("emailac", doctor.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("roleidac", doctor.Roleid, dbType: DbType.Int32, ParameterDirection.Input);
            
            var result = dBContext.Connection.Execute("Doctor_package.CreateDoctor", p, commandType: CommandType.StoredProcedure);
        }

        //Update doctor
        public void updatedoctor(DoctorRegister doctor)
        {
            var p = new DynamicParameters();
            p.Add("DICTORACID", doctor.Doctodid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("firstnameAc", doctor.Firstname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("lastnameAc", doctor.Lastname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("imagenameAc", doctor.Imagename, dbType: DbType.String, ParameterDirection.Input);
            p.Add("levelAc", doctor.Level1, dbType: DbType.String, ParameterDirection.Input);
            p.Add("CATEGORYIDAC", doctor.Categoryid, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("USERNAMEAC", doctor.Username, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PASSWORDAC", doctor.Password, dbType: DbType.String, ParameterDirection.Input);
            p.Add("EMAILAC", doctor.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("roleidac", doctor.Roleid, dbType: DbType.Int32, ParameterDirection.Input);
            dBContext.Connection.Execute("Doctor_package.UpdateDoctor", p, commandType: CommandType.StoredProcedure);
        }

        //delete
        public void Deletedoctor(int doctorid)
        {
            var p = new DynamicParameters();
            p.Add("Id", doctorid, dbType: DbType.Int32, ParameterDirection.Input);
            var result = dBContext.Connection.Execute("Doctor_package.DeleteDoctor", p, commandType: CommandType.StoredProcedure);
        }

        public List<SearchByName> GetDocByName(string thename)
        {
            var p = new DynamicParameters();
            p.Add("nameac", thename, dbType: DbType.String, ParameterDirection.Input);
            IEnumerable<SearchByName> result = dBContext.Connection.Query<SearchByName>("Doctor_package.SearchDoctorByName",p,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public docBy getbyid(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            var x = dBContext.Connection.Query<docBy>("Doctor_package.GetById", p, commandType: CommandType.StoredProcedure);
            return x.FirstOrDefault();
        }



        public docBy GetByLoginId(string id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, ParameterDirection.Input);
            var x = dBContext.Connection.Query<docBy>("Doctor_package.GetByLoginId", p, commandType: CommandType.StoredProcedure);
            return x.FirstOrDefault();
        }

    }
}
