using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScreenScraper.Core.Components;


//var searchTerm = args[0];
var searchTerm = "Jordan 4";

var driver = new ChromeDriver();
driver.Url = "https://ebay.com";
driver.Navigate();

var searchBox = driver.FindElement(By.Id("gh-ac"));
searchBox.SendKeys(searchTerm);
new TextBoxComponent(driver).FindElement(By.Id("gh-ac")).SendKeys(searchTerm);

var searchButton = driver.FindElement(By.Id("gh-btn"));
searchButton.Click();
new ClickComponent(driver).FindElement(By.Id("gh-btn")).Click();

var resultsContainer = driver.FindElement(By.Id("srp-river-results"));
//searchResults.GetAttribute("innerHTML");

var searchResults = resultsContainer.FindElements(By.ClassName("s-item"));
Console.WriteLine($"search results = {searchResults.Count}");

foreach (var item in searchResults)
{
    var titleElement = item.FindElement(By.ClassName("s-item__title"));
    var title = titleElement.GetAttribute("innerHTML");
    title = title.Split("-->")[1];
    title = title.Split("<!--")[0];
    Console.WriteLine(title);

    var priceElement = item.FindElement(By.ClassName("s-item__price"));
    var price = priceElement.GetAttribute("innerHTML");
    price = price.Replace("<!--F#f_0--><!--F#f_0-->", "");
    price = price.Split("<!--")[0];
    Console.WriteLine(price);
}

Console.ReadLine();