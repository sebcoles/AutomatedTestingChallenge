using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutomatedTestingChallenge.Web.Models;
using AutomatedTestingChallenge.Logic;
using System.Threading;

namespace AutomatedTestingChallenge.Web.Controllers
{
    public class CalculatorController : Controller
    {
        private CalcService _calcService;

        public CalculatorController()
        {
            _calcService = new CalcService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new CalcModel());
        }

        [HttpGet]
        public IActionResult Subtract()
        {
            return View(new CalcModel());
        }

        [HttpGet]
        public IActionResult Multiply()
        {
            return View(new CalcModel());
        }

        [HttpGet]
        public IActionResult Divide()
        {
            return View(new CalcModel());
        }

        [HttpPost]
        public IActionResult Add(CalcModel model)
        {
            var result = _calcService.Add(Int32.Parse(model.num1), Int32.Parse(model.num2));
            model.result = result;
            return View(model);
        }

        [HttpPost]
        public IActionResult Subtract(CalcModel model)
        {
            var result = _calcService.Subtract(Int32.Parse(model.num1), Int32.Parse(model.num2));
            model.result = result;
            return View(model);
        }

        [HttpPost]
        public IActionResult Multiply(CalcModel model)
        {
            Thread.Sleep(3000);
            var result = _calcService.Multiply(Int32.Parse(model.num1), Int32.Parse(model.num2));
            model.result = result;
            return View(model);
        }

        [HttpPost]
        public IActionResult Divide(CalcModel model)
        {
            if (model.num1.Equals("0"))
                return BadRequest("Cannot divide by 0");

            var result = _calcService.Divide(Int32.Parse(model.num1), Int32.Parse(model.num2));
            model.result = result;
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
