using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class ExceptionDivideByZero : Exception
    {
        public ExceptionDivideByZero()
        {
            Console.WriteLine("cannot divide by zero");
        }
    }

    public class ExceptionImaginaryNumber : Exception
    {
        public ExceptionImaginaryNumber()
        {
            Console.WriteLine("exponent most be positive numbers");
        }
    }
}
