using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Parkeezzi.DataAccess;
using Parkeezzi.Services;

namespace Parkeezzi
{
   public class Startup
   {
      // This method gets called by the runtime. Use this method to add services to the container.
      // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
      public void ConfigureServices(IServiceCollection services)
      {
         var connection = @"Server=(localdb)\mssqllocaldb;Database=Parkeezzi;Trusted_Connection=True;ConnectRetryCount=0";
         services.AddDbContext<ParkeezziContext>(options => options.UseSqlServer(connection));
         services.AddScoped<ContractorService>();
         services.AddMvc();
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IHostingEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }

         app.UseMvcWithDefaultRoute();
      }
   }
}
