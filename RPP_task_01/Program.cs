using System;
using System.Numerics;

namespace RPP_task_01
{
    /// <summary>
    /// A class that implements the mathematical function factorial,
    /// applied to non-negative integers, equal to the product of all
    /// natural numbers from 0 to the number for which it is calculated.
    /// </summary>
    public static class Factorial
    {
        /// <summary>
        /// A function that implements the calculation of the factorial.
        /// </summary>
        /// <param name="N">Natural number.</param>
        /// <returns></returns>
        public static BigInteger Result(BigInteger N)
        {
            BigInteger res = 1;

            if (N > 0)
            {
                for (BigInteger i = N; i > 0; i--)
                {
                    res *= i;
                }
            }
            return res;
        }
    }
    /// <summary>
    /// A class that implements the formula 1/0! + 1/1! +...+ 1/ N!, where
    /// "!" this is the factorial of a number, and "N" is a natural number.
    /// </summary>
    public static class Formula
    {
        /// <summary>
        /// A function that implements the formula 1/0! + 1/1! +...+ 1/ N!,
        /// where "!" is the factorial of a number, and "N" is a natural number.
        /// </summary>
        /// <param name="N">Natural number.</param>
        /// <returns></returns>
        public static double Result(BigInteger N)
        {
            double res = 0;

            for (BigInteger i = N; i >= 0; i--)
            {
                res += 1 / ((double)Factorial.Result(i));
            }

            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления формулы 1/0! + 1/1! +...+ 1/N!:");

            BigInteger N; 

            if(BigInteger.TryParse(Console.ReadLine(), out N))
            {
                double res = Formula.Result(N);

                Console.WriteLine("Результат: " + res);
            }
            else Console.WriteLine("Введите корректное число!");
        }
    }
}
