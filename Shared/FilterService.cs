using System.Collections.Generic;
using System;

namespace WebsiteOPr.Shared
{
	public class FilterService
	{
		public enum Language
		{
			English,
			Norwegian,
			Japanese,
			Korean
		}

		public bool Loading { get; set; } = true;
		public TextModel Text { get; set; }
		private Language CurrentLang { get; set; }
		public Dictionary<int, string> Languages = new Dictionary<int, string>();

		// Create dic with Key corresponding to Language enum and the display text as Value.
		public FilterService()
		{
			Languages.Add(0, "English");
			Languages.Add(1, "Norsk");
			Languages.Add(2, "日本語");
			Languages.Add(3, "한국어");
		}
		
		public string GetText(int key)
		{
			string text = "";
			switch (CurrentLang)
			{
				case Language.English:
					text = Text.English[key];
					break;
				case Language.Norwegian:
					text = Text.Norwegian[key];
					break;
				case Language.Japanese:
					text = Text.Japanese[key];
					break;
				case Language.Korean:
					text = Text.Korean[key];
					break;
			}
			return text;
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