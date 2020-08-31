using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatedTestingChallenge.Tests.Web.AcceptanceTests.PageObjects
{
    public class CalcPageObject
    {
        private readonly IWebDriver _webDriver;

        public CalcPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public IWebElement Num1InputBox => _webDriver.FindElement(By.Id("num1"));
        public IWebElement Num2InputBox => _webDriver.FindElement(By.Id("num2"));
        public IWebElement SubmitButton => _webDriver.FindElement(By.Id("submit"));
        public IWebElement Result => _webDriver.FindElement(By.Id("result"));
    }
}
