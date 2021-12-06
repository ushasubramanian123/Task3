using NUnit.Framework;
using System;
using System.IO;
using System.Text;  
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task3
{
    
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            string title = driver.Title;
            int titleLength = title.Length;
            Console.WriteLine("The title is " +title + " and the length is "+ titleLength);
            string pageURL = driver.Url;
            int pageURLLength = pageURL.Length;
            Console.WriteLine("The Page URL is " +pageURL + " and the page URL length is " + pageURLLength);
            String pageSource = driver.PageSource;
            int pageSourceLength = pageSource.Length;
            Console.WriteLine("The Page URL is " + pageSource + " and the page URL length is " + pageSourceLength);
            driver.Close();
            Assert.Pass();
        }
    }
}