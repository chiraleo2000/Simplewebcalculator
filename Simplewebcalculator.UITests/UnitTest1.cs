using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace WebApp.UITests
{
    [TestClass]
    public class CalculatorUITests : IDisposable
    {
        private IWebDriver driver;
        private string appUrl;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            appUrl = GetAppUrl();
        }

        private string GetAppUrl()
        {
            var jsonPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "appsettings.json");
            var json = File.ReadAllText(jsonPath);
            var jObject = JObject.Parse(json);
            return jObject["AppSettings"]["appUrl"].ToString();
        }


        [TestMethod]
        public void Add_TwoNumbers_UITest()
        {
            driver.Navigate().GoToUrl(appUrl);
            driver.FindElement(By.Id("ValueA")).SendKeys("5");
            driver.FindElement(By.Id("ValueB")).SendKeys("3");
            driver.FindElement(By.CssSelector("button[value='Add']")).Click();
            Thread.Sleep(1000); // Wait for response

            var result = driver.FindElement(By.Id("Result")).GetAttribute("value");
            Assert.AreEqual("8", result);
        }

        // Additional UI tests for Subtract, Multiply, Divide

        public void Dispose()
        {
            driver?.Quit();
        }
    }
}
