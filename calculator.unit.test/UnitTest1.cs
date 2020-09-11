using System;
using NUnit.Framework;
using Calculator;
// so you need to add dependency, make the class public and add the namespace to project

namespace calculator.unit.test
{
    [TestFixture]

    public class CalculatorTests
    {
        private Calculator_class uut;
        readonly double Precision = 0.015;
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

        public void Add(double a, double b, double c)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(c));
        }

        [TestCase(4, 4)]
        [TestCase(-1, -1)]
        [TestCase(50, 50)]
        [TestCase(50.595959, 50.60)] // test af afrunding
        [TestCase(-5030, -5030)]
        public void Add_Single(double a, double result)
        {
            Assert.That(uut.Add(a), Is.EqualTo(result));
        }

        [TestCase(4, 2, 2)]
        [TestCase(10, 7, 3)]
        [TestCase(55, 10, 45)]
        [TestCase(8, -6, 14)]
        [TestCase(-4, 4, -8)]
        [TestCase(-3, 6, -9)]
        public void Subtract(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }
        [TestCase(4, -4)]
        [TestCase(-1, 1)]
        [TestCase(50, -50)]
        [TestCase(50.595959, -50.60)] // test af afrunding
        [TestCase(-5030, 5030)]
        public void Subtract_Single(double a, double result)
        {
            Assert.That(uut.Subtract(a), Is.EqualTo(result));
        }

        // Multiply //
        [TestCase(4, 2, 8)]
        [TestCase(10, 7, 70)]
        [TestCase(12, 10, 120)]
        [TestCase(6, -6, -36)]
        [TestCase(-4, -4, 16)]
        [TestCase(-3, 6, -18)]
        public void Multiply(double a, double b, double c)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(10, 7, 70)]
        [TestCase(10, -2, -20)]
        [TestCase(10, 10, 100)]
        [TestCase(20, 5.5, 110)]
        [TestCase(125.12343, 5.5, 688.16)]
        public void Multiply_Single(double startValue, double a, double result)
        {
            uut.Add(startValue);

            Assert.That(uut.Multiply(a), Is.EqualTo(result).Within(Precision));
        }

        // Divide //
        [TestCase(6, 2, 3)]
        [TestCase(50, 5, 10)]
        [TestCase(8, 1, 8)]
        public void Divide(double a, double b, double c)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(c));
        }

        [TestCase(2, 5)]
        [TestCase(-5, -2)]
        [TestCase(4, 2.5)]
        public void Divide_Single(double a, double result)
        {
            uut.Add(10);
            Assert.That(uut.Divide(a), Is.EqualTo(result));
        }

        [TestCase(10)]
        [TestCase(0)]
        public void Divide_ByZero(double a)
        {
            uut.Add(a);
            Console.WriteLine(uut.Accumulator);
            Assert.Catch<ExceptionDivideByZero>(() => uut.Divide(6, 0));
            Assert.That(uut.Accumulator, Is.EqualTo(a));
        }

        // Power //
        [TestCase(10, 2, 100)]
        [TestCase(-5, 2, 25)]
        [TestCase(1, -1, 1)]
        [TestCase(-4, 3, -64)]
        [TestCase(234567.3332, 10.54788, 4.4150688277476919E+56)]
        [TestCase(0.2344556644566, 10.5478823467899, 0.000000227)]
        public void Power(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(c).Within(Precision));
        }

        [TestCase(10, 2, 100)]
        [TestCase(1, -1, 1)]
        [TestCase(-4, 3, -64)]
        [TestCase(234567.33, 10.547, 4.3672854664322518E+56d)]
        [TestCase(0.23, 10.5478823467899, 0.000000227)]
        public void Power_Single(double a, double b, double c)
        {
            // a added to the accumulator.
            uut.Add(a);
            Assert.That(uut.Power(b), Is.EqualTo(c).Within(Precision));
        }
        [Test]
        public void Power_NoImaginaryNumbers()
        {
            Assert.Catch<ExceptionImaginaryNumber>(() => uut.Power(-5, 0.5));
        }

        // Accumulator
        [TestCase(2)]
        [TestCase(-2)]
        public void Accumulator_Get(double a)
        {
            uut.Add(a);
            Assert.That(uut.Accumulator, Is.EqualTo(a));

            uut.Add(a);
            Assert.That(uut.Accumulator, Is.EqualTo(a + a));
        }
        [Test]
        public void Accumulator_Clear()
        {
            uut.Subtract(10);
            Assert.That(uut.Accumulator, Is.EqualTo(-10));

            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }


    }
}