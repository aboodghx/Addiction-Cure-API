using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using Addiction_Cure.core.Common;
using Addiction_Cure.infra.Repository;
using Addiction_Cure.infra.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stripe;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Addiction_Cure
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("policy",
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            services.Configure<KestrelServerOptions>(options =>
            {
                options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(2);
            });

            services.AddScoped<IDBContext, DBContext>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IReqRepository, ReqRepository>();
            services.AddScoped<IReqService, ReqService>();
            services.AddScoped<IPatientRepostory, PatientRepostory>();
            services.AddScoped<IAboutUsRepository, AboutUsRepository>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<IHomeRepository, HomeRepository>();

            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IAboutUsService, AboutUsService>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddScoped<IBankService, BankService>();
            services.AddScoped<IHomeService, HomeService>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IQuastionRepository, QuastionRepository>();
            services.AddScoped<IQuastionService, QuastionService>();
            services.AddScoped<ITestimonialsRepository, TestimonialsRepository>();
            services.AddScoped<ITestimonialsService, TestimonialsService>();

            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<ITestService, TestService>();
            services.AddScoped<IResultTestRepository, ResultTestRepository>();
            services.AddScoped<IResultTestService, ResultTestService>();
            services.AddControllers();

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme =
                JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new
                    SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("policy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
