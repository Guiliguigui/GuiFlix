using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using GuiFlix_Repositories.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GuiFlix_API", Version = "v1" });
            });

            string connectionString = Configuration.GetConnectionString("GuiFlixDB");
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(connectionString));

            services.AddScoped<IRepository<Admin>,AdminRepository>();
            services.AddScoped<IRepository<Account>, AccountRepository>();
            services.AddScoped<IRepository<Profile>,ProfileRepository>();
            services.AddScoped<IRepository<Like>,LikeRepository>();
            services.AddScoped<IRepository<List>,ListRepository>();
            services.AddScoped<IRepository<Media>,MediaRepository>();
            services.AddScoped<IRepository<CrewMember>,CrewMemberRepository>();
            services.AddScoped<IRepository<Category>,CategoryRepository>();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
