using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace hwapp
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      loggerFactory.AddConsole();

      /*if (env.IsDevelopment())
      {
          app.UseDeveloperExceptionPage();
      }*/

      app.UseMvcWithDefaultRoute();

      /* app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Hello World");
      });*/
    }
  }

}
