﻿using System;
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
            // burde Accumulator dimsen ikke blive opdateret her?
            // return Math.Pow(a, exp);
            Accumulator = Math.Pow(a, exp);
            return Accumulator;
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
            try
            {
                Accumulator /= divisor;
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("cannot divide by zero");
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