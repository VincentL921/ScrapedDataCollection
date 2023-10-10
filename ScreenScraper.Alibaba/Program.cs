using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using ScreenScraper.Core.Components;


//var searchTerm = args[0];
var searchTerm = "video game racing wheel";

var driver = new ChromeDriver();
driver.Url = "https://alibaba.com";
driver.Navigate();

new TextBoxComponent(driver).FindElement(By.ClassName("J-keyword ui-searchbar-keyword")).SendKeys(searchTerm);

new ButtonComponent(driver).FindElement(By.ClassName("ui-searchbar-button-icon")).Click();

Thread.Sleep(1500);

Console.ReadLine();
