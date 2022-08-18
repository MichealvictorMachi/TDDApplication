using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDApplication;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]        
        [DataRow("50", "70","120")]
        [DataRow("510", "90", "600")]
        [DataRow("800", "320", "1120")]


        public void BasicAddictionTest(string x, string y, string expected)
        {

            var calculator = new Calculator();
            int num1 = Int32.Parse(x);
            int num2 = Int32.Parse(y);
            int expectedRes = int.Parse(expected);

            var total = calculator.Addition(num1, num2);
            Assert.AreEqual(expectedRes, total);
        }
        
    }
}