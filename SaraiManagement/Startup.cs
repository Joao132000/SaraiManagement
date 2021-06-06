using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using SaraiManagement.Models.Classes;
using SaraiManagement.Models.ClassesEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Http;

namespace SaraiManagement
{
    public class Startup
    {
        ///Davi
        public Startup(IConfiguration configuration) => Configuration = configuration; 
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:SaraiManagement2021:ConnectionString"]));
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".Sarai.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(300);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IAlunoRepositorio, EFAluno>();
            services.AddTransient<IDoacaoRepositorio, EFDoacao>();
            services.AddTransient<IDonatarioRepositorio, EFDonatario>();
            services.AddTransient<IDoadorRepositorio, EFDoador>();
            services.AddTransient<ICaixaRepositorio, EFCaixa>();
            services.AddTransient<IMovimentacaoRepositorio, EFMovimentacao>();
            services.AddTransient<IUsuarioRepositorio, EFUsuario>();
            services.AddTransient<IItemDoadoRepositorio, EFItemDoado>();
            services.AddTransient<IEstoqueRepositorio, EFEstoque>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id?}", defaults: new { controller = "TelaInicial", action = "Sobre" });
            });
           // SeedData.EnsurePopulated(app);
        }
    }
}
