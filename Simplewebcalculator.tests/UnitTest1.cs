using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simplewebcalculator.Controllers;
using Simplewebcalculator.Models;

namespace Simplewebcalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private HomeController controller;

        [TestInitialize]
        public void Setup()
        {
            controller = new HomeController();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var model = new CalculatorModel { ValueA = 5, ValueB = 3 };
            controller.Index(model, "Add");
            Assert.AreEqual(8, model.Result);
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            var model = new CalculatorModel { ValueA = 5, ValueB = 3 };
            controller.Index(model, "Subtract");
            Assert.AreEqual(2, model.Result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var model = new CalculatorModel { ValueA = 5, ValueB = 3 };
            controller.Index(model, "Multiply");
            Assert.AreEqual(15, model.Result);
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            var model = new CalculatorModel { ValueA = 6, ValueB = 3 };
            controller.Index(model, "Divide");
            Assert.AreEqual(2, model.Result);
        }

        [TestMethod]
        public void Divide_ByZero_ReturnsZero()
        {
            var model = new CalculatorModel { ValueA = 5, ValueB = 0 };
            controller.Index(model, "Divide");
            Assert.AreEqual(0, model.Result);
        }
    }
}
