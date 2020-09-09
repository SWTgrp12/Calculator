using NUnit.Framework;
using Calculator;
// so you need to add dependency, make the class public and add the namespace to project

namespace calculator.unit.test
{
    [TestFixture]

    public class CalculatorTests
    {
        private Calculator_class uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator_class();
        }
        // testcase example below
        [TestCase(2, 6, 8)]
        [TestCase(4, 6, 10)]
        [TestCase(6, 6, 12)]
        [TestCase(8, -6, 2)]
        [TestCase(-4, -4, -8)]
        [TestCase(-3, 6, 3)]

        public void TestAddition(double a, double b, double c)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(c));
        }

        [TestCase(4, 2, 2)]
        [TestCase(10, 7, 3)]
        [TestCase(55, 10, 45)]
        [TestCase(8, -6, 14)]
        [TestCase(-4, 4, -8)]
        [TestCase(-3, 6, -9)]
        public void TestSubtraction(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(4, 2, 8)]
        [TestCase(10, 7, 70)]
        [TestCase(12, 10, 120)]
        [TestCase(6, -6, -36)]
        [TestCase(-4, -4, 16)]
        [TestCase(-3, 6, -18)]
        public void TestMultiply(double a, double b, double c)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c));
        }


        [TestCase(4, 2, 16)]
        [TestCase(10, 2, 100)]
        [TestCase(-5, 2, 25)]
        [TestCase(1, -1, 1)]
        [TestCase(-4, 3, -64)]
        [TestCase(-3, 3, -27)]

        public void TestPower(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(c));
        }
    }
}