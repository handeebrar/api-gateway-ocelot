using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Reservation.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://*:9001");
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}