using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace AutomatedTestingChallenge.Tests.Api.AcceptanceTests.Drivers
{
    public interface ICalculatorApiDriver
    {
        HttpResponseMessage Add(string a, string b);
    }

    public class CalculatorApiDriver : ICalculatorApiDriver
    {
        private HttpClient _client;
        private string _baseUrl = "https://localhost:44340/api/calculatorapi/";
        public CalculatorApiDriver()
        {
            _client = new HttpClient();
        }

        public HttpResponseMessage Add(string a, string b)
        {
            return _client.GetAsync($"{_baseUrl}Add?a={a}&b={b}").Result;
        }
    }
}
