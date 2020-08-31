using System;
using System.Threading;
using global::AutomatedTestingChallenge.Logic;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedTestingChallenge.Web.Controllers
{
    namespace AutomatedTestingChallenge.Web.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class CalculatorApiController : ControllerBase
        {
            private CalcService _calcService;

            public CalculatorApiController()
            {
                _calcService = new CalcService();
            }
            [HttpGet]
            public IActionResult Index()
            {
                return Ok("Use actions Add, Subtract, Multiply & Divide with parameters 'a' and 'b'\n\nfor example: /calculator/add?a=10&b=5");
            }

            [HttpGet]
            [Route("Add")]
            public IActionResult Add(string a, string b)
            {
                var result = _calcService.Add(Int32.Parse(a), Int32.Parse(b));
                return Ok(result);
            }

            [HttpGet]
            [Route("Subtract")]
            public IActionResult Subtract(string a, string b)
            {
                var result = _calcService.Subtract(Int32.Parse(a), Int32.Parse(b));
                return Ok(result);
            }

            [HttpGet]
            [Route("Multiply")]
            public IActionResult Mulitply(string a, string b)
            {
                Thread.Sleep(3000);
                var result = _calcService.Multiply(Int32.Parse(a), Int32.Parse(b));
                return Ok(result);
            }

            [HttpGet]
            [Route("Divide")]
            public IActionResult Divide(string a, string b)
            {
                if (a.Equals("0"))
                    return BadRequest("Cannot divide by 0");

                var result = _calcService.Divide(Int32.Parse(a), Int32.Parse(b));
                return Ok(result);
            }
        }
    }

}
