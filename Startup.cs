using Fiap01.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{

    public void ConfigureServices(IServiceCollection services)
    {
        var connection =@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";

        services.AddDbContext<PerguntasContext>(o => o.UseSqlServer(connection));

        services.AddMvc();
    }
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        //app.Run(async (context) =>
        //{
        //    await context.Response.WriteAsync("Espero que funcione");

        //});

        if(env.IsDevelopment())

        app.UseDeveloperExceptionPage();

        app.UseStaticFiles();

        app.UseMvc(routes =>
        {
            //    routes.MapRoute(
            //        name: "autor",
            //        template: "autor/{nome}",
            //        defaults:new { controller="Autor", action="Index" });

            //    routes.MapRoute(
            //       name: "autoresDoAno",
            //       template: "{ano:int}/autor",
            //       defaults: new { controller = "Autor", action = "ListaDosAutoresDoAno" });

            //    routes.MapRoute(
            //       name: "topicosdacategoria",
            //       template: "{categoria}/{topico}",
            //       defaults: new { controller = "Topicos", action = "Index" });

            routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");



        });

        //Route Constrain



    }
}
