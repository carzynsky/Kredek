using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArkadiuszCarzynskiLab7Zadanie.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ArkadiuszCarzynskiLab7Zadanie.Services;

namespace ArkadiuszCarzynskiLab7Zadanie
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
            var connection = @"Server=DESKTOP-U4VRK31;Database=FootballManagment;Trusted_Connection=True;";
            services.AddDbContext<FootballManagmentContext>(options => options.UseSqlServer(connection));
            services.AddTransient<IFootballerService, FootballerService>();
            services.AddTransient<IClubService, ClubService>();
            services.AddControllers();
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
