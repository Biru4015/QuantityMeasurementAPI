namespace QuantityMeasurementAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using QuantityMeasurementManager.IQuantityManager;
    using QuantityMeasurementManager.QuantityManager;
    using QuantityMeasurementRepository;
    using QuantityMeasurementRepository.IRepository;
    using QuantityMeasurementRepository.Repository;
    using Swashbuckle.AspNetCore.Swagger;
    using Oracle.ManagedDataAccess.Client;

    /// <summary>
    /// This class contains the code of startup.cs
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<UserDbContext>(options => options.UseOracle(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IQuantityMeasurementManager, QuantityMeasurementManagers>();
            services.AddTransient<IQuantityRepository, QuantityRepository>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "QuantiyMeasurementAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "QuantiyMeasurementAPI V1");
                });
            }
            else
            {
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseDefaultFiles();
            app.UseHttpsRedirection();
            app.UseMvcWithDefaultRoute();
        }
    }
}