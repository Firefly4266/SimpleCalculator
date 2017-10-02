using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        //create a read only instance of CalculatorEngine so we can call it's methods for testing.  This ca only be done if SimpleCalculator is added as a reference since it is a class in the SimpleCalculstor name space.
        private readonly CalculatorEngine calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddMethodUsingTextOperatorTest()
        {
            //setting up data for testing
            int firstNumber = 5;
            int secondNumber = 3;
            //need to add add SimpleCalculator to out references so we can use it to actually test it's functionality.
            double result = calculatorEngine.Calculate("add", firstNumber, secondNumber);

            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void AddMethodUsingSymbolOperatorTest()
        {
            //setting up data for testing
            int firstNumber = 5;
            int secondNumber = 3;
            //need to add add SimpleCalculator to out references so we can use it to actually test it's functionality.
            double result = calculatorEngine.Calculate("+", firstNumber, secondNumber);

            Assert.AreEqual(8, result);
        }
    }
}
