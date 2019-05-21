<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MonolegalApi.BL;
using MonolegalApi.Models;
using MonolegalApi.Services;

namespace MonolegalApi
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
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                builder =>
                {
                    builder.WithOrigins("http://localhost/",
                                        "http://localhost:4200/")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod(); ;
                });
            });
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.Configure<DBConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            services.AddSingleton<IEmailSender, EmailSender>();
            services.AddScoped<IClienteService,ClienteService>();
            services.AddScoped<IFacturacionProceso, FacturacionProceso>();
            services.AddScoped<IEstadoFacturaStrategy, EstadoFacturaStrategy>();
            services.AddScoped<IEstadoOperador, PrimerRecordatorio>();
            services.AddScoped<IEstadoOperador, SegundoRecordatorio>();
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
                app.UseHsts();
            }
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MonolegalApi.BL;
using MonolegalApi.Models;
using MonolegalApi.Services;

namespace MonolegalApi
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
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                builder =>
                {
                    builder.WithOrigins("http://localhost/",
                                        "http://localhost:4200/")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod(); ;
                });
            });
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.Configure<DBConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            services.AddSingleton<IEmailSender, EmailSender>();
            services.AddScoped<IClienteService,ClienteService>();
            services.AddScoped<IFacturacionProceso, FacturacionProceso>();
            services.AddScoped<IEstadoFacturaStrategy, EstadoFacturaStrategy>();
            services.AddScoped<IEstadoOperador, PrimerRecordatorio>();
            services.AddScoped<IEstadoOperador, SegundoRecordatorio>();
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
                app.UseHsts();
            }
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
>>>>>>> 9bd5cb3e33341e4627f0d1eab90da82dc9784e56
