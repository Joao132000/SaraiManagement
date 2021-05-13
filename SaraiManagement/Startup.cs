using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using SaraiManagement.Models.Classes;
using SaraiManagement.Models.ClassesEF;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace SaraiManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:SaraiManagement2021:ConnectionString"]));
            services.AddTransient<IAlunoRepositorio, EFAluno>();
            services.AddTransient<IDoacaoRepositorio, EFDoacao>();
            services.AddTransient<IDonatarioRepositorio, EFDonatario>();
            services.AddTransient<IDoadorRepositorio, EFDoador>();
            services.AddTransient<ICaixaRepositorio, EFCaixa>();
            services.AddTransient<IMovimentacaoRepositorio, EFMovimentacao>();
            services.AddTransient<IUsuarioRepositorio, EFUsuario>();
            services.AddTransient<IItemDoadoRepositorio, EFItemDoado>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Configura a aplicação em si
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();//redireciona a pagina para uma exceção, famoso erro 404, para tratar quando não encontra a view
            app.UseStaticFiles();//São os arquivos utilizados na formatação,javascript, bootstrap....CSS....na pasta www.root
            app.UseRouting();//usado para compor a rota,rota é o caminho que aponta o caminho,como é exibido na barra de endereços
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id?}",
                defaults: new { controller = "Index", Action = "Index" });
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
