using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertInputToNumericTest()
        {
            string input = "25";
            double convertedStringToNumericTest = inputConverter.ConvertInputToNumeric(input);

            Assert.AreEqual(25, convertedStringToNumericTest);
        }

        //testing exception functionality.  
        [TestMethod]
        //this says to pass expect an exception (of type ArgumentException) to be thrown...otherwise the test fails.
        [ExpectedException(typeof(ArgumentException))]
        public void failsToConvertInputTest()
        {
            string input = "anything not a number";
            double convertedStringToNumericTest = inputConverter.ConvertInputToNumeric(input);

            Assert.AreEqual(25, convertedStringToNumericTest);
        }
    }
}
