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
			BasePath = Environment.CurrentDirectory + "\\Data\\";
		}

		// Returns Text based on the Language enum.
		[HttpGet("text/{lang}")]
		public TextModel GetTextService(int lang)
		{
			return JsonConvert.DeserializeObject<TextModel>(File.ReadAllText(BasePath + "Text.json"));
		}
	}
}