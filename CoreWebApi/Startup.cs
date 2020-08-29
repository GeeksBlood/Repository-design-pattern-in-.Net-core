using AutoMapper;
using Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Repository.Interface;
using Repository.UOW;
using Services;
using Services.IServices;
using System;

namespace CoreWebApi
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

            // Auto Mapper Configurations
            services.AddAutoMapper();
            Mapper.Initialize(cfg => { cfg.AddProfile<MappingProfile>(); });

            services.AddDbContext<MyCompanyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmployees, EmployeesService>();
            services.AddScoped(typeof(IGenericRepostory<>), typeof(GenericRepostory<>));

            // Swagger 
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Info
            //    {
            //        Title = "DA API",
            //        Version = "v1",
            //    });

            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
