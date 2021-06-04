namespace ApiSaludar
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Server.IIS;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.IdentityModel.Logging;
    using Microsoft.OpenApi.Models;
    using Saludar.Business.Business;
    using Saludar.Business.IBusiness;
    using Saludar.DataAccess;
    using Saludar.DataAccess.IRepositories;
    using Saludar.DataAccess.Repositories;
    using System;
    using System.IO;
    using System.Reflection;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private readonly string EnableCors = "EnableCORS";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });



            services.AddCors(options =>
            {
                options.AddPolicy(EnableCors, builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build();
                });
            });

            services.AddControllers();

            services.AddDbContext<SaludarDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataBaseConexion")));

            services.AddScoped<IIdiomaBusiness, IdiomaBusiness>();
            services.AddScoped<ISaludoBusiness, SaludoBusiness>();
            services.AddScoped<IAccionBotonBusiness, AccionBotonBusiness>();

            services.AddScoped<IIdiomaRepository, IdiomaRepository>();
            services.AddScoped<ISaludoRepository, SaludoRepository>();
            services.AddScoped<IAccionBotonRepository, AccionBotonRepository>();

            services.AddAuthentication(IISServerDefaults.AuthenticationScheme);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Saludar", Version = "v1" });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "Api Saludar v1"));

            if (env.IsDevelopment())
            {
                IdentityModelEventSource.ShowPII = true;
                app.UseDeveloperExceptionPage();
                
            }

            app.UseRouting();

            app.UseCors(EnableCors);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}