using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScreenScraper.Core;
using ScreenScraper.Core.Components;


namespace ScreenScraper.Bodega
{
	public class BodegaScraper : IScraper
	{
		public BodegaScraper()
        {
		}

		public void Run(string searchTerm)
		{
            string encodedSearchTerm = Uri.EscapeDataString(searchTerm);
            var driver = new ChromeDriver();
            driver.Url = "https://bdgastore.com/collections/search-results?q=" + encodedSearchTerm;
            driver.Navigate();

            //Some trial & error code i used before going the query route - VL 10/16/23
            //new TextBoxComponent(driver).FindElement(By.Id("Search")).SendKeys(searchTerm);
            //new ButtonComponent(driver).FindElement(By.ClassName("search-results")).Click();
            //new Actions(driver).SendKeys(Keys.Escape);
        }
	}
}

