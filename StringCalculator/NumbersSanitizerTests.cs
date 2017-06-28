using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator
{

    [TestClass]
    public class NumbersSanitizerTests
    {
        [TestMethod]
        public void GivenAddMethod_WhenContainsSeperatorSpecifier_ReturnsSumOfNumbers()
        {
            NumbersSanitizer numbersSanitizer = new NumbersSanitizer(',');
            var result = numbersSanitizer.SanitizeNumbers("//;\n1;2");
            Assert.AreEqual("1,2", result);
        }
    }
}
