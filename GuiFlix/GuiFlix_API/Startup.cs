using GuiFlix_API.Helpers;
using GuiFlix_API.Services;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using GuiFlix_Repositories.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_API
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
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddCors();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GuiFlix_API", Version = "v1" });
            });

            string connectionString = Configuration.GetConnectionString("GuiFlixDB");
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(connectionString));

            services.AddScoped<IRepository<Admin>, AdminRepository>();
            services.AddScoped<IRepository<Account>, AccountRepository>();
            services.AddScoped<IRepository<Profile>, ProfileRepository>();
            services.AddScoped<IRepository<Like>, LikeRepository>();
            services.AddScoped<IRepository<List>, ListRepository>();
            services.AddScoped<IRepository<Media>, MediaRepository>();
            services.AddScoped<IRepository<CrewMember>, CrewMemberRepository>();
            services.AddScoped<IRepository<Category>, CategoryRepository>();
            services.AddScoped<IRepository<Question>, QuestionRepository>();

            var apiSettingsSection = Configuration.GetSection("APISettings");
            services.Configure<APISettings>(apiSettingsSection);

            var apiSettings = apiSettingsSection.Get<APISettings>();
            var key = Encoding.ASCII.GetBytes(apiSettings.SecretKey!);

            services.AddScoped<ICryptPasswordService>(x => new CryptPasswordService(apiSettings.SecretKey!));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = apiSettings.ValidIssuer,
                    ValidateAudience = true,
                    ValidAudience = apiSettings.ValidAudience
                };
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy(Constants.RoleAdminAccount, police =>
                {
                    police.RequireClaim(ClaimTypes.Role, Constants.RoleAdminAccount);

                });
                options.AddPolicy(Constants.RoleUserAccount, police =>
                {
                    police.RequireClaim(ClaimTypes.Role, Constants.RoleUserAccount);
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GuiFlix_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        }
    }
}
