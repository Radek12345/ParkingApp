﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ParkingApp.API.Core;
using ParkingApp.API.Core.Repositories;
using ParkingApp.API.Persistence;
using ParkingApp.API.Persistence.Repositories;

namespace ParkingApp.API
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
            services.AddDbContext<ParkingDbContext>(options => 
                options.UseSqlServer(Configuration["ConnectionString:Default"]));

            services.AddAutoMapper();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // app.UseHsts();
            }

            // app.UseHttpsRedirection();
            app.UseCors(o => o.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseMvc();
        }
    }
}
