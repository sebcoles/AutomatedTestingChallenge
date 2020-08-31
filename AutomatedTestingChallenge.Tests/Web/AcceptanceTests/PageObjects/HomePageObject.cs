using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatedTestingChallenge.Tests.Web.AcceptanceTests.PageObjects
{
    public class HomePageObject
    {
        private readonly IWebDriver _webDriver;

        public HomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public IWebElement AddLink => _webDriver.FindElement(By.Id("addlink"));
        public IWebElement SubtractLink => _webDriver.FindElement(By.Id("subtractlink"));
        public IWebElement MultiplyLink => _webDriver.FindElement(By.Id("multiplylink"));
        public IWebElement DivideLink => _webDriver.FindElement(By.Id("dividelink"));
    }
}
