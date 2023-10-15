using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using ScreenScraper.Core.Components;


//var searchTerm = args[0];
var searchTerm = "Jordan 4";

var driver = new ChromeDriver();
driver.Url = "https://www.stadiumgoods.com/en-us/shopping?pageindex=1&query=";
driver.Navigate();


//new ClickComponent(driver).FindElement(By.ClassName("e53yhoa0")).Click();
//new TextBoxComponent(driver).FindElement(By.Id("search-input")).SendKeys(searchTerm);
//new ClickComponent(driver).FindElement(By.ClassName("e113g3kc0")).Click();
//new Actions(driver).SendKeys(Keys.Enter);


Console.ReadLine();