using Microsoft.AspNetCore.Mvc;
using Simplewebcalculator.Models;

namespace Simplewebcalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model, string command)
        {
            switch (command)
            {
                case "Add":
                    model.Result = model.ValueA + model.ValueB;
                    break;
                case "Subtract":
                    model.Result = model.ValueA - model.ValueB;
                    break;
                case "Multiply":
                    model.Result = model.ValueA * model.ValueB;
                    break;
                case "Divide":
                    model.Result = model.ValueB != 0 ? model.ValueA / model.ValueB : 0;
                    break;
            }
            return View(model);
        }
    }
}
