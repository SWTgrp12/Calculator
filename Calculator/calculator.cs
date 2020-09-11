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
            Accumulator = Math.Round(Accumulator, 2);
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            Accumulator = Math.Round(Accumulator, 2);
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            Accumulator = Math.Round(Accumulator, 2);
            return Accumulator;

        }
        public double Divide(double dividend, double divisor) // arseniy
        {
            if (divisor == 0)
            {
                throw new ExceptionDivideByZero();
            }
            else
            {
                Accumulator = dividend / divisor;
                Accumulator = Math.Round(Accumulator, 2);
            }
            return Accumulator;
        }

        public double Power(double a, double exp) // 
        {
            // vi skal have en exception i den her stil for at undgå imaginære tal 
            if (a < 0.0 && exp < 1 && exp > -1.0)
            {
                throw new ExceptionImaginaryNumber();
            }
            else
            {
                Accumulator = Math.Pow(a, exp);
                Accumulator = Math.Round(Accumulator, 2);
            }
            return Accumulator;
        }

        public double Accumulator { get; private set; } = 0; // 0 is default

        public void Clear()
        {
            Accumulator = 0;
        }

        // overloaded single input functions
        public double Add(double addend)
        {
            Accumulator += addend;
            Accumulator = Math.Round(Accumulator, 2);
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            Accumulator = Math.Round(Accumulator, 2);
            return Accumulator;
        }

        public double Multiply(double multiplier) // pav
        {
            Accumulator *= multiplier;
            Accumulator = Math.Round(Accumulator, 2);
            return Accumulator;
        }

        public double Divide(double divisor) // pav
        {
            Accumulator = Divide(Accumulator, divisor);
            return Accumulator;
        }
        public double Power(double exponent) // arseniy
        {
            Accumulator = Power(Accumulator, exponent);
            return Accumulator;
        }
    }
}