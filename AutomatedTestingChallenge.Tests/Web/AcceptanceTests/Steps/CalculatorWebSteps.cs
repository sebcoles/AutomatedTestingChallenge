using AutomatedTestingChallenge.Tests.Web.AcceptanceTests.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomatedTestingChallenge.Tests.Web.AcceptanceTests.Steps
{
    [Binding]
    public class CalculatorWebSteps
    {
        private ISeleniumWebDriver _driver;
        private string a;
        private string b;
        private string _result;
        private Stopwatch _timer;

        public CalculatorWebSteps()
        {
            _driver = new SeleniumWebDriver();
            _timer = new Stopwatch();
        }

        [Given(@"I browse to the home page")]
        public void GivenIBrowseToTheHomePage()
        {
            _timer.Start();
            _driver.Navigate("");
        }

        [Given(@"I click the '(.*)' link")]
        public void GivenIClickTheLink(string p0)
        {
            _driver.ClickLink(p0);
        }


        [Given(@"I enter '(.*)' and '(.*)' into the web form")]
        public void GivenIEnterAndIntoTheWebForm(int p0, int p1)
        {
            _driver.EnterNumber(p0, "num1");
            _driver.EnterNumber(p1, "num2");
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            _driver.Submit();
        }
        
        [Then(@"the I should see the answer '(.*)' appear on the page")]
        public void ThenTheIShouldSeeTheAnswerAppearOnThePage(string p0)
        {
            Assert.AreEqual(p0, _driver.Result());
            _timer.Stop();
        }

        [Then(@"this should complete within '(.*)' milliseconds")]
        public void ThenThisShouldCompleteWithinMilliseconds(int p0)
        {
            Assert.IsTrue(p0 > _timer.Elapsed.TotalMilliseconds);
        }

    }
}
