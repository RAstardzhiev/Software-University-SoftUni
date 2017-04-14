using Calculator_CSharp.Models;
using System.Web.Mvc;
using System;

namespace Calculator_CSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public ActionResult Calculate(Calculator calculator)
        {
            calculator.Result = CalculateResult(calculator);

            return RedirectToAction("Index", calculator);
        }

        private decimal CalculateResult(Calculator calculator)
        {
            var result = 0m;

            switch (calculator.Operator)
            {
                case "+":
                    result = calculator.LeftOperand + calculator.RightOperand;
                    break;
                case "-":
                    result = calculator.LeftOperand - calculator.RightOperand;
                    break;
                case "*":
                    result = calculator.LeftOperand * calculator.RightOperand;
                    break;
                case "/":
                    result = calculator.LeftOperand / calculator.RightOperand;
                    break;
                case "Reminder":
                    result = calculator.LeftOperand % calculator.RightOperand;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}