using System;
using OpenQA.Selenium;

namespace ScreenScraper.Core.Components
{
	public class ButtonComponent : ClickComponent
	{
        private readonly IWebDriver _driver;

        public ButtonComponent(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
    }
}

