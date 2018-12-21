using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace DemoServer
{
    internal class Program
    {
        private const string WebRoot = "demo";
        private static string ContentRoot => $"{Directory.GetCurrentDirectory()}";

        private static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return new WebHostBuilder().UseKestrel().UseContentRoot(ContentRoot).UseWebRoot(WebRoot)
                .UseStartup<StartUp>();
        }
    }
}