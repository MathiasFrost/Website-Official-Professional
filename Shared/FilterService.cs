using System.Collections.Generic;

namespace WebsiteOPr.Shared
{
	public class FilterService
	{
		public enum Language
		{
			Random,
			English,
			Norwegian,
			Japanese
		}

		public bool Loading { get; set; } = true;
		public Language CurrentLang { get; set; }
		public Dictionary<int, string> Languages = new Dictionary<int, string>();

		public FilterService()
		{
			Languages.Add(0, "English");
			Languages.Add(1, "Norsk");
			Languages.Add(2, "日本語");
		}
	}
}