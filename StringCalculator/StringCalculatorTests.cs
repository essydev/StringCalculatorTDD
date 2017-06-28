using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator
{
    [TestClass]
    public class StringCalculatorTests
    {
        //Arrange
        //Act
        //Assert
        
        [TestMethod]
        public void GivenAddMethod_ThenReturn0_WhenEmptyString()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GivenAddMethod_WhenSingleNumber_ThenReturnNumber()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GivenAddMethod_WhenMultipleNumbers_ThenReturnSumOfNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GivenAddMethod_WhenUnknownAmountOfNumbers_ThenReturnSumOfNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2,3");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void GivenAddMethod_WhenNumberSplitWithNewLine_ReturnsSumOfNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void GivenAddMethod_WhenContainsSeperatorSpecifier_ThenReturnSumOfNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("//;\n1;2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GivenAddMethod_WhenContainingNegativeNumbers_ExcludesThemFromSum()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,-2,3");
            Assert.AreEqual(4, result);
        }
    }
}
