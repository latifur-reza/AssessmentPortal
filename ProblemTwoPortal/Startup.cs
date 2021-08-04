using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProblemTwoPortal.Configurations;
using ProblemTwoPortal.Database.AssessmentDB;
using ProblemTwoPortal.Database.Seeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // All cors
        readonly string AllowAll = "AllowAll";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Allow all

            services.AddCors(options =>
            {
                options.AddPolicy(AllowAll, policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            #endregion

            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson();

            #region Mysql Connection string from appSettings

            var dbConnetionStringSection = Configuration.GetSection("ConnectionString");
            services.Configure<DbConnectionSettings>(dbConnetionStringSection);
            var dbConnectionSettings = dbConnetionStringSection.Get<DbConnectionSettings>();
            services.AddDbContext<AssessmentDbContext>(options => options.UseMySql(dbConnectionSettings.AssessmentDbConnection));

            #endregion

            // Register all services
            services.RegisterServices();

            

            SeedRegister.IntializeSeedData(dbConnectionSettings.AssessmentDbConnection);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(AllowAll);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
