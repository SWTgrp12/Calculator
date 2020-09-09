using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator_class
    {
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;

        }

        public double Power(double a, double exp) // pav
        {
            return Math.Pow(a, exp);
        }

        public double Divide(double dividend, double divisor) // arseniy
        {
            try
            {
                Accumulator = dividend / divisor;
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("cannot divide by zero");
            }

            return Accumulator;

        }

        public double Accumulator { get; private set; } = 0; // 0 is default

        public void Clear()
        {
            Accumulator = 0;
        }

        // jer 2 start
        public double Add(double addend)
        {
            return 0;
        }

        public double Subtract(double subtractor)
        {
            return 0;
        }

        public double Multiply(double multiplier) // pav
        {
            return 0;

        }

        public double Divide(double divisor) // pav
        {
            return 0;

        }
        ///////// jer 2 slut
        public double Power(double exponent) // arseniy
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;

        }
    }
}