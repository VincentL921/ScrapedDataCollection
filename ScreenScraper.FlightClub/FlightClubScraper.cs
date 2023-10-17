using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScreenScraper.Core;
using ScreenScraper.Core.Components;

namespace ScreenScraper.FlightClub
{
    public class FlightClubScraper : IScraper
    {
        public FlightClubScraper()
        {
        }

        public void Run(string searchTerm)
        {
            var driver = new ChromeDriver();
            driver.Url = "https://flightclub.com/catalogsearch/result?query=";
            driver.Navigate();

            //Some trial & error code i used before going the query route - VL 10/15/23
            //new ButtonComponent(driver).FindElement(By.Id("NavigationSearchInput")).Click();
            //new TextBoxComponent(driver).FindElement(By.Id("NavigationSearchInput")).SendKeys(searchTerm);
            ////new ButtonComponent(driver).FindElement(By.Id("/catalogsearch/result?query=")).Click();
            ////new Actions(driver).SendKeys(Keys.Enter);
            ////new Actions(driver).SendKeys(Keys.Escape);
            ////new ButtonComponent(driver).FindElement(By.ClassName("sc-hAQmFe jZbdAH")).Click();

        }
    }
}

