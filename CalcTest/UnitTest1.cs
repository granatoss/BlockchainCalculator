using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSub()
        {
            //Arrange
            var oper1 = "Div";
            var oper2 = "Sum";
            var oper3 = "Mult";
            var oper4 = "Sub";
            double a = 10;
            double b = 2.5;

            //Act

            var result = Calc.MyResult(a, b, oper1);
            var result1 = Calc.MyResult(a, b, oper2);
            var result2 = Calc.MyResult(a, b, oper3);
            var result3 = Calc.MyResult(a, b, oper4);
            //Assert
            Assert.AreEqual(4, result);
            Assert.AreEqual(12.5, result1);
            Assert.AreEqual(25, result2);
            Assert.AreEqual(7.5, result3);
            Console.ReadKey();
        }
    }
}
