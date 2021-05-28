using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace SeleniumTest
{
    class SeleniumTestClass
    {
         IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("E:\\COURSES\\chromedriver");
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void goToHomePage()
        {
            driver.Url = "http://localhost:27490/";
            Thread.Sleep(500);
        }

        [Test]
        public void AddTicket()
        {
            driver.Url = "http://localhost:27490/";
            Thread.Sleep(10000);

            IWebElement addTicketLink = driver.FindElement(By.XPath("//ul/li/a[@href='/addticket']"));
            addTicketLink.Click();

            IWebElement concertFiel = driver.FindElement(By.Id("concert"));
            concertFiel.Click();
            concertFiel.SendKeys("Raspberry jam");

            IWebElement PhoneNumberFiel = driver.FindElement(By.Id("PhoneNumber"));
            PhoneNumberFiel.Click();
            PhoneNumberFiel.SendKeys("+375295632159");

            IWebElement PriceUSDFiel = driver.FindElement(By.Id("PriceUSD"));
            PriceUSDFiel.Click();
            PriceUSDFiel.SendKeys("21");
            Thread.Sleep(4000);

            IWebElement sendButton = driver.FindElement(By.XPath("//form/button"));
        }

            [TearDown]
       
            public void closeBrowser()
        {
            driver.Close();
        }
    }
}
