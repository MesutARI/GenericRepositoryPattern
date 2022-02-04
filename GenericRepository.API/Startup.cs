
using AutoMapper;
using GenericRepository.API.Mapping;
using GenericRepository.Core.Repositories;
using GenericRepository.Core.Services;
using GenericRepository.Core.UnitOfWorks;
using GenericRepository.DataAccess.Contexts;
using GenericRepository.DataAccess.Repositories;
using GenericRepository.Service.Services;
using GenericRepository.Service.UnitOfWorks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GenericRepository
{
    public class Startup
    {
        #region variables

        public IConfiguration Configuration { get; }

        #endregion

        #region Startup
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region ConfigureServices
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddDbContext<NorthwindContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("NorthwindConnectionString")));

            //services.AddDbContext<NorthwindContext>(options =>
            //{
            //    options.UseSqlServer(Configuration["ConnectionStrings:NorthwindConnectionString"]);
            //});
            services.AddMvc(); //.SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers();

            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
        #endregion

        #region Configure
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
        #endregion
    }
}
