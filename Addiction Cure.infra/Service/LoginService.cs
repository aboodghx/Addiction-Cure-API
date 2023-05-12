using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class LoginService: ILoginService
    {
        //inject from repo
        private readonly ILoginRepository loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        public String Login(Loginac login)
        {
            var result = loginRepository.login(login);
            if (result == null)
                return null;
            else
            {
                // secret key
                var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                // signin credentials
                var signinCredentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
                {
                new Claim("Name", result.Username),
                new Claim("Role", result.Roleid.ToString()),
                new Claim("loginid", result.Loginid.ToString())};
                // token options
                var tokenOptions = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddSeconds(10),
                signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions); return tokenString;
            }
        }
        public bool register(Register patient)
        {
            return loginRepository.register(patient);
        }


        public bool DoctorRegister(DoctorRegister doctorRegister)
        {
            return loginRepository.DoctorRegister(doctorRegister);
        }

        public Dictorac DoctorId(string id)
        {
            return loginRepository.DoctorId(id);
        }


        public Patientac patientid(string id)
        { 
            return loginRepository.patientid(id);
        }

    }
}
