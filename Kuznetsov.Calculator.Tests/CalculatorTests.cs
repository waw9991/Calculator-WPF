using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kuznetsov.Calculator.Logic;
using System;

namespace Kuznetsov.Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Kuznetsov.Calculator.Logic.Calculator _calc = null!;

        [TestInitialize]
        public void Setup()
        {
            _calc = new Kuznetsov.Calculator.Logic.Calculator();
        }

        [TestMethod]
        public void Add_PositiveNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(7.0, _calc.Add(3, 4), 0.001);
        }

        [TestMethod]
        public void Subtract_NegativeResult_ReturnsCorrectResult()
        {
            Assert.AreEqual(-2.0, _calc.Subtract(3, 5), 0.001);
        }

        [TestMethod]
        public void Multiply_Zero_ReturnsZero()
        {
            Assert.AreEqual(0.0, _calc.Multiply(100, 0), 0.001);
        }

        [TestMethod]
        public void Divide_ValidInput_ReturnsCorrectResult()
        {
            Assert.AreEqual(2.5, _calc.Divide(10, 4), 0.001);
        }

        //[TestMethod]
        //public void Divide_ByZero_ThrowsException()
        //{
        //    Assert.ThrowsException<System.DivideByZeroException>(() => _calc.Divide(10, 0));
        //}

        [TestMethod]
        public void Power_Square_ReturnsCorrectResult()
        {
            Assert.AreEqual(16.0, _calc.Power(4, 2), 0.001);
        }
    }
}