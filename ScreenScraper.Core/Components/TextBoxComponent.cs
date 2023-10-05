using System;
using OpenQA.Selenium;

namespace ScreenScraper.Core.Components
{
	public class TextBoxComponent : InputComponent
	{
		private readonly IWebDriver _driver;

		public TextBoxComponent(IWebDriver driver) : base(driver)
		{
			_driver = driver;
		}
	}
}

