using Aplicacao.Servico.Teste;
using Aplicacao.Teste.Interface;
using AutoMapper;
using Dominio.Teste.Servico;
using Dominio.Teste.Servico.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.Linq;
using System.Reflection;

namespace Web.RPG
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [System.Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromAssemblyOf<TesteAppServico>()
                    .AddClasses()
                        .AsImplementedInterfaces()
                        .WithScopedLifetime());

            services.Scan(scan => scan
                .FromAssemblyOf<TesteServico>()
                    .AddClasses()
                        .AsImplementedInterfaces()
                        .WithScopedLifetime());

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(
                    "v1",
                    new Info
                    {
                        Title = "API Ficha customizavel de RPG",
                        Description = "RPG"
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "RPG");
            });
        }
    }
}
