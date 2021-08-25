namespace BarsUp.WebHost
{
    using System;
    using System.Text;
    using BarsUp.Web;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    public partial class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            var hostBuilder = WebHost
                              .CreateDefaultBuilder()
                              .UseBarsUpDefaults(args)
                              .UseKestrel(o => o.Limits.MaxRequestBodySize = null)
                              .UseIISIntegration()
                              .UseStartup<BarsUpMvcStartup>();

            hostBuilder = ConfigureHostBuilder(hostBuilder, args);

            hostBuilder.Build().Run();
        }
    }
}