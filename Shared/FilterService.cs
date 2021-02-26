using System.Collections.Generic;
using System;

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

		// Create dic with Key corresponding to Language enum and the display text as Value.
		public FilterService()
		{
			Languages.Add(1, "English");
			Languages.Add(2, "Norsk");
			Languages.Add(3, "日本語");
		}

		public event Action OnLangChange;

		// Method for setting CurrentLang that invokes OnLangChange.
		public void SetLanguage(Language value)
		{
			CurrentLang = value;
			NotifyLangChanged();
		}

		private void NotifyLangChanged() => OnLangChange?.Invoke();
	}
}