﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using ScreenScraper.Core.Components;


//var searchTerm = args[0];
var searchTerm = "Aime Leon Dore New Balance";

var driver = new ChromeDriver();
driver.Url = "https://stadiumgoods.com";
driver.Navigate();
Thread.Sleep(1000);
new TextBoxComponent(driver).FindElement(By.XPath(".//button[@data-test='desktopHeader-searchButton']")).Click();
new TextBoxComponent(driver).FindElement(By.Id("search-input")).SendKeys(searchTerm);
new Actions(driver).SendKeys(Keys.Enter);

//wanted to test out stadium goods on a whim before starting a new job
//StockX wouldn't grant me access because it was from test software lol - VL 10/10/23

//new ButtonComponent(driver).FindElement(By.ClassName("")).Click();


Thread.Sleep(1500);

Console.ReadLine();