using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._2
{
    internal class SimpleMath
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
        public static float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return (double)a / b;
        }
    }
}
