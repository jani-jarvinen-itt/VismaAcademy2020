using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            // arrange
            int a = 100;
            int b = 200;
            Calculations calc = new Calculations();

            // act
            int sum = calc.Sum(a, b);

            // assert
            int expected = a + b;
            Assert.AreEqual(expected, sum);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // testi 1
            int a = 5;
            int b = 10;

            Calculations calc = new Calculations();
            int result = calc.Multiply(a, b);

            int expected = a * b;
            Assert.AreEqual(expected, result);

            // testi 2
            a = -5;
            b = -10;
            result = calc.Multiply(a, b);
            expected = a * b;
            Assert.AreEqual(expected, result);

            // testi 3
            a = -5;
            b = 0;
            result = calc.Multiply(a, b);
            expected = a * b;
            Assert.AreEqual(expected, result);
        }
    }
}