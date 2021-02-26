using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebsiteOPr.Shared;
using Blazored.SessionStorage;

namespace WebsiteOPr.Client
{
	public class Program
	{
		// Just adding services.
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");
			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			builder.Services.AddSingleton<FilterService>();
			builder.Services.AddBlazoredSessionStorage();
			await builder.Build().RunAsync();
		}
	}
}