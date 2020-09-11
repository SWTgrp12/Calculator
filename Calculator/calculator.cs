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
            // vi skal have en exception i den her stil for at undgå imaginære tal 
            if (a < 0.0 && exp < 1 && exp > -1.0)
            {
                Console.WriteLine("cannot take root of negative number");
            }
            else Accumulator = Math.Pow(a, exp);

            return Accumulator;
        }

        public double Divide(double dividend, double divisor) // arseniy
        {
            try
            {
                throw new ExceptionDivideByZero();
            }

            Accumulator = dividend / divisor;
            
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
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier) // pav
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        public double Divide(double divisor) // pav
        {
            if (divisor == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                // throw new System.DivideByZeroException();
            }
            else Accumulator /= divisor;

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                    
            }
            return Accumulator;
        }
        ///////// jer 2 slut
        public double Power(double exponent) // arseniy
        {
            // vi skal have en exception i den her stil for at undgå imaginære tal
            if (Accumulator < 0.0 && exponent < 1.0 && exponent > -1.0)
            {
                Console.WriteLine("cannot take root of negative number");
            }

            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;

        }
    }
}