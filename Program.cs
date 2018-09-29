using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Fiap01
{
    class Program
    {
        static void Main(string[] args)
        {
            //var intervalo = new Intervalo();
            // Console.WriteLine("Hello World!");            
            BuildWebHost(args).Run();

        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }
}
