using System.Collections.Generic;

namespace WebsiteOPr.Shared
{
	public class TextModel
	{
		public string Welcome { get; set; } = "";
		public string Intro { get; set; } = "";

		public Dictionary<string, string> GetTexts()
		{
			Dictionary<string, string> texts = new Dictionary<string, string>
			{
				{ "Welcome", Welcome },
				{ "Intro", Intro }
			};
			return texts;
		}
	}
}