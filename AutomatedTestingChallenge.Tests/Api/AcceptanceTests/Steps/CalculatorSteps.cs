using AutomatedTestingChallenge.Tests.Api.AcceptanceTests.Drivers;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomatedTestingChallenge.Tests.Api.AcceptanceTests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private ICalculatorApiDriver _calculatorApiDriver;
        private string a;
        private string b;
        private HttpResponseMessage _returnMessage;
        private Stopwatch _timer;

        public CalculatorSteps()
        {
            _calculatorApiDriver = new CalculatorApiDriver();
            _timer = new Stopwatch();
        }

        [Given(@"the first number is '(.*)' and the second number is '(.*)'")]
        public void GivenTheFirstNumberIsAndTheSecondNumberIs(string p0, string p1)
        {
            a = p0;
            b = p1;
        }             
        
        [When(@"the two numbers are send to the Add API")]
        public void WhenTheTwoNumbersAreSendToTheAddAPI()
        {
            _timer.Start();
            _returnMessage = _calculatorApiDriver.Add(a, b);
            _timer.Stop();
        }

        [Then(@"the result response should be '(.*)'")]
        public void ThenTheResultResponseShouldBe(string p0)
        {
            var response = _returnMessage.Content.ReadAsStringAsync().Result;
            Assert.AreEqual(p0, response);
        }
        
        [Then(@"the request should complete within '(.*)' milliseconds")]
        public void ThenTheRequestShouldCompleteWithinSecond(int p0)
        {
            Assert.IsTrue(p0 > _timer.Elapsed.TotalMilliseconds);
        }
    }
}
