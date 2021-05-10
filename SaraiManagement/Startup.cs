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
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace SaraiManagement
{
    public class Startup
    {
        ///Davi
        public Startup(IConfiguration configuration) => Configuration = configuration; 
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:SaraiManagement:ConnectionString"]));
            //services.AddTransient<IAlunoRepositorio, EFAlunoRepositorio>();
            //services.AddTransient<IDoacaoRepositorio, EFDoacaoRepositorio>();
            //services.AddTransient<IDonatarioRepositorio, EFDonatarioRepositorio>();
            //services.AddTransient<IDoadorRepositorio, EFDoadorRepositorio>();
            //services.AddTransient<ICaixaRepositorio, EFCaixaRepositorio>();
            //services.AddTransient<IMovimentacaoRepositorio, EFMovimentacaoRepositorio>();
            //services.AddTransient<IUsuarioRepositorio, EFUsuarioRepositorio>();
            //services.AddTransient<IItemDoadoRepositorio, EFItemDoadoRepositorio>();
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
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id?}", defaults: new { controller = "Index", action = "Index" });
            });
            //SeedData.EnsurePopulated(app);

           //Davi
        }
    }
}
