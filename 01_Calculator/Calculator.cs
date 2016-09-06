using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Sum(int[] numbers)
        {
           return numbers[0] + numbers[1];  
        }

        internal static int Add(int a1, int a2)
        {
            return a1 + a2;
        }

        internal static int Subtract(int s1, int s2)
        {
            return s1 - s2;
        }

        internal static int Multiply(int m1, int m2)
        {
            return m1 * m2;
        }

        internal static double Power(int p1, int p2)
        {
            return Math.Pow(p1, p2);
        }

        internal static int Factorial(int x1)
        {
            int sum = x1;
             for (int x = x1-1; x > 0; x--)
            {
                sum = sum * x;
            }
            return sum;
        }
    }
}