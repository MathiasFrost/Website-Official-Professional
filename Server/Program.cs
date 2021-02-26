using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WebsiteOPr.Server
{
	public class Program
	{
		// Just create builder.
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		// Just configure builder.
		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
	}
}