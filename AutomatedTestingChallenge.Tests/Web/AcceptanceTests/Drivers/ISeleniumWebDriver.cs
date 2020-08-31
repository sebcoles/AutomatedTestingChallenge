using AutomatedTestingChallenge.Tests.Web.AcceptanceTests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatedTestingChallenge.Tests.Web.AcceptanceTests.Drivers
{
    public interface ISeleniumWebDriver
    {
        void Navigate(string path);
        void ClickLink(string link);
        void EnterNumber(int number, string textbox);
        void Submit();
        string Result();
    }

    public class SeleniumWebDriver : ISeleniumWebDriver
    {
        private readonly IWebDriver _driver;
        private string _baseUrl = "https://localhost:44399/";

        public SeleniumWebDriver()
        {
            _driver = new ChromeDriver(@"C:\tools");
        }
        public void Navigate(string path)
        {
            _driver.Navigate().GoToUrl(_baseUrl + path);
        }

        public void ClickLink(string link)
        {
            var homePageObject = new HomePageObject(_driver);
            IWebElement linkElement;
            switch (link)
            {
                case "Add":
                    linkElement = homePageObject.AddLink;
                    break;
                default:
                    throw new ArgumentException(link);
            }

            linkElement.Click();            
        }

        public void EnterNumber(int number, string textbox)
        {
            var pageObject = new CalcPageObject(_driver);
            IWebElement inputElement;
            switch (textbox)
            {
                case "num1":
                    inputElement = pageObject.Num1InputBox;
                    break;
                case "num2":
                    inputElement = pageObject.Num2InputBox;
                    break;
                default:
                    throw new ArgumentException(textbox);
            }

            inputElement.Clear();
            inputElement.SendKeys(number.ToString());
        }

        public void Submit()
        {
            var homePageObject = new CalcPageObject(_driver);
            homePageObject.SubmitButton.Click();
        }

        public string Result()
        {
            var homePageObject = new CalcPageObject(_driver);
            return homePageObject.Result.Text;
        }
    }
}
