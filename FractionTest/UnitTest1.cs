using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionMath;

namespace FractionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            Fraction f1 = new Fraction("1/4");
            Fraction f2 = new Fraction("2/8");
            Fraction f3 = f1 + f2;
            Assert.AreEqual(f3.ToString(), "2/4");
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Fraction f1 = new Fraction("3/4");
            Fraction f2 = new Fraction("2/8");
            Fraction f3 = f1 - f2;
            Assert.AreEqual(f3.ToString(), "2/4");
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Fraction f1 = new Fraction("1/2");
            Fraction f2 = new Fraction("1/2");
            Fraction f3 = f1 * f2;
            Assert.AreEqual(f3.ToString(), "1/4");
        }

        [TestMethod]
        public void TestDivision()
        {
            Fraction f1 = new Fraction("1/2");
            Fraction f2 = new Fraction("1/2");
            Fraction f3 = f1 / f2;
            Assert.AreEqual(f3.ToString(), "1/1");
        }

        [TestMethod]
        public void TestLessThan()
        {
            Fraction f1 = new Fraction("1/8");
            Fraction f2 = new Fraction("1/2");
            
            Assert.IsTrue(f1<f2);
        }

        [TestMethod]
        public void TestGreaterThan()
        {
            Fraction f1 = new Fraction("1/2");
            Fraction f2 = new Fraction("1/4");

            Assert.IsTrue(f1 > f2);
        }
    }
}
