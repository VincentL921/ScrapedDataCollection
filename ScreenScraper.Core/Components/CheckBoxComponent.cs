using System;
using OpenQA.Selenium;

namespace ScreenScraper.Core.Components
{
	public class CheckBoxComponent : ClickComponent
	{
		private readonly IWebDriver _driver;

		public CheckBoxComponent(IWebDriver driver) : base(driver)
		{
			_driver = driver;
		}
	}
}

