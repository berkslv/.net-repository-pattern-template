using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Security.Entities;
using Core.Utilities.Security.Helpers.Encryption;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace WebAPI
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
            // Controller altyapısını açar.
            services.AddControllers();

            // localhost:3000 den gelen her başlığı kabul eder. CORS policy uygulamaz.
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("http://localhost:3000"));
            });

            // appsettings.json içerisinde TokenOptions başlığını TokenOptions.cs olarak alır.
            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            // Kimlik doğrulama için konfigurasyonlar.
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters=new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Eğer geliştirme aşamasında ise
            if (env.IsDevelopment())
            {
                // Geliştirici hata sayfasınu kullan.
                app.UseDeveloperExceptionPage();
            }

            // localhost:3000 den gelen her başlığı kabul eder. CORS policy uygulamaz.
            app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader());

            // Https yönlendirme yapar.
            app.UseHttpsRedirection();
            
            app.UseRouting();

            // Kimlik doğrulama sistemini açar.
            app.UseAuthentication();

            // Yetkilendirme sistemini açar
            app.UseAuthorization();

            // Endpoint yani adresleri controller içerisinden belirleriz.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
