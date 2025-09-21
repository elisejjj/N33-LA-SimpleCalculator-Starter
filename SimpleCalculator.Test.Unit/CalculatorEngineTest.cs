using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void SubstractsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 1;
            double result = _calculatorEngine.Calculate("-", number1, number2);
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 4;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("*", number1, number2);
            Assert.AreEqual(8, result);

        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 4;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("/", number1, number2);
            Assert.AreEqual(2, result);

        }
    }
}
