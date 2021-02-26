using System;
using WebsiteOPr.Shared;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;

namespace WebsiteOPr.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MainController
	{
		private readonly string BasePath;

		public MainController()
		{
			BasePath = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ? "../Server/Data/" : "D:/home/site/wwwroot/Data/";
		}

		[HttpGet]
		[Route("text")]
		public TextService GetTextService()
		{
			return JsonConvert.DeserializeObject<TextService>(File.ReadAllText(BasePath + "English.json"));
		}
	}
}
