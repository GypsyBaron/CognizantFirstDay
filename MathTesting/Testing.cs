using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;

namespace MathTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void Math_WhenTwoCorrectNumberSumIsCorrect_TestShouldPass()
        {
            var math = new Arithmetics();
            int num1;
            int num2;
            int expectedResult;
            num1 = 12;
            num2 = 8;
            expectedResult = 20;

            int actualResult = math.Add(num1, num2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Math_WhenTwoCorrectNumberSubtractIsCorrect_TestShouldPass()
        {
            var math = new Arithmetics();
            int num1;
            int num2;
            int expectedResult;
            num1 = 12;
            num2 = 3;
            expectedResult = 9;

            int actualResult = math.Minus(num1, num2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}