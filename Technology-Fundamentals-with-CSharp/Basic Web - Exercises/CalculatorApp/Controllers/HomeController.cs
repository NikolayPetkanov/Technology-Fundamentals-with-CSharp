using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CalculatorApp.Controllers;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Input data is invalid. Please use valid numbers!";
            }

            if (calculator.Operator == "/" && calculator.RightOperand == 0)
            {
                TempData["InvalidDivision"] = "Can not divide by zero!";
            }

            else
            {
                calculator.CalculateResult();
                History.CalculationsHistory.Add(calculator);
            }

            return RedirectToAction("Index", calculator);
        }

        [HttpGet]
        public IActionResult CalculationsHistory()
        {
            return View(History.CalculationsHistory);
        }
    }
}
