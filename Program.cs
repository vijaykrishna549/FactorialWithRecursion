using System;

namespace Factorial_Without_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            long factorial = FactorialCalculate(n);
            Console.WriteLine(" The factorial of {0} is : {1} ", n, factorial);
            Console.ReadKey();
        }

        private static long FactorialCalculate(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * FactorialCalculate(n - 1);
        }
    }
}
