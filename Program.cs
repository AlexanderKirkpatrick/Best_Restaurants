using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Best_Restaurants
{
    public class Program
    {
        public static void Main(string[] args)
        {
        var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build();

        host.Run();
        }
    }
}
