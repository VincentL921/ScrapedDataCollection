using System;
using OpenQA.Selenium;

namespace ScreenScraper.Core.Components
{
	public class ClickComponent : ElementComponent
	{
		private readonly IWebDriver _driver;

		public ClickComponent(IWebDriver driver) : base(driver)
		{
			_driver = driver;
		}

        public void Click()
        {
            Element.Click();
        }

    }
}


