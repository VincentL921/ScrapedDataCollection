using System;
using OpenQA.Selenium;

namespace ScreenScraper.Core.Components
{
	public class InputComponent : ElementComponent
	{
		private IWebDriver _driver;

		public InputComponent(IWebDriver driver) : base(driver)
		{
			_driver = driver;
		}

		public void SendKeys(string value)
		{
			Element.SendKeys(value);
		}
	}
}

