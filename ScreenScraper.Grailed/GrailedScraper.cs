﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScreenScraper.Core;
using ScreenScraper.Core.Components;

namespace ScreenScraper.Grailed
{
    public class GrailedScraper : IScraper
    {
        public GrailedScraper()
        {
        }

        public void Run(string searchTerm)
        {
            string encodedSearchTerm = Uri.EscapeDataString(searchTerm);
            var driver = new ChromeDriver();
            driver.Url = "https://www.grailed.com/shop/" + encodedSearchTerm;
            driver.Navigate();
        }
    }
}

