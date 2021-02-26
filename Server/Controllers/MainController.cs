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

		// Sets correct Base Path for files in the Data folder.
		public MainController()
		{
			BasePath = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ? "../Server/Data/" : "D:/home/site/wwwroot/Data/";
		}

		// Returns Text based on the Language enum.
		[HttpGet("text/{lang}")]
		public TextModel GetTextService(int lang)
		{
			FilterService.Language language = (FilterService.Language)lang;
			return JsonConvert.DeserializeObject<TextModel>(File.ReadAllText(BasePath + language.ToString() + ".json"));
		}
	}
}