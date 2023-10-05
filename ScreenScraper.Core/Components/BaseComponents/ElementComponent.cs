using System;
using OpenQA.Selenium;

namespace ScreenScraper.Core.Components
{
	public class ElementComponent
	{
		private readonly IWebDriver _driver;
		public IWebElement Element { get; private set; }

		public ElementComponent (IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement FindElement(By by)
		{
			Element = _driver.FindElement(by);
			return Element;
		}
	}
}

