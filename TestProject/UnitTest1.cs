using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDApplication;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicAddictionTest()
        {

            var calculator = new Calculator();
            int total = calculator.Addition(100, 20);
            Assert.AreEqual(120, total);
        }
        //public void BasicSubstractionTest()
        //{

        //    var calculator = new Calculator();
        //    int total = calculator.Substraction(100, 20);
        //    Assert.AreEqual(80, total);
        //}
    }
}