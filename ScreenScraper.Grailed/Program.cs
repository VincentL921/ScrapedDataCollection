using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using ScreenScraper.Core.Components;


//var searchTerm = args[0];
var searchTerm = "Aime Leon Dore Hoodie New Balance";

var driver = new ChromeDriver();
driver.Url = "https://grailed.com";
driver.Navigate();

new TextBoxComponent(driver).FindElement(By.Id("header_search-input")).SendKeys(searchTerm);

new ButtonComponent(driver).FindElement(By.ClassName("Form-module__searchButton___WDphC")).Click();


//Thread.Sleep(1500);

//new ClickComponent(driver).FindElement(By.ClassName("Modal-Header-Title")).Click();

//new Actions(driver).SendKeys(Keys.Escape);

//new TextBoxComponent(driver).FindElement(By.Id("header_search-input")).SendKeys(searchTerm);

//new ButtonComponent(driver).FindElement(By.ClassName("Form-module__searchButton___WDphC")).Click();

//var resultsContainer = driver.FindElement(By.Id("srp-river-results"));
//searchResults.GetAttribute("innerHTML");

//var searchResults = resultsContainer.FindElements(By.ClassName("s-item"));
//Console.WriteLine($"search results = {searchResults.Count}");

Console.ReadLine();