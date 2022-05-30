using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSum()
        {
            double firstNum = 7, secondNum = 13;
            double expected = firstNum + secondNum;

            double actual = Program.Plus(firstNum, secondNum);

            Assert.AreEqual(expected, actual, 0.1, "Погрешность вышла за границу 0.1");
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethodDelit()
        {
            double firstNum = 6, secondNum = 0;
            double expected = firstNum / secondNum;

            double actual = Program.Delit(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDelit2()
        {
            double firstNum = 9, secondNum = 4;
            double expected = firstNum / secondNum;

            double actual = Program.Delit(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodMinus()
        {
            double firstNum = 7, secondNum = 13;
            double expected = firstNum - secondNum;

            double actual = Program.Minus(firstNum, secondNum);

            Assert.AreEqual(expected, actual, 0.1, "Погрешность 0.1");
        }
        [TestMethod]
        public void TestMethodUmnoj()
        {
            double firstNum = 7, secondNum = 13;
            double expected = firstNum * secondNum;

            double actual = Program.Umnoj(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }
    }
}
