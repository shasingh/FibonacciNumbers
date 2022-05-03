using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciNumbers
{
    public class CalcFibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci number at(n):");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci number at "+i+" is: "+FibNumAtN(i));
            Console.WriteLine();
            Console.WriteLine("Enter any number:");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.Write(j + " is Fibonacci: " + IsFibNumber(j));

        }

        public static int FibNumAtN(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibNumAtN(n - 1) + FibNumAtN(n - 2);
            }
        }

        public static bool IsFibNumber(int n)
        {
            int a = 0;
            int b = 1;
            if (n == a || n == b)
            {                
                Console.WriteLine("Closest index is: " + n);
                return true;
            }

            int c = a + b;

            int index = 2;

            while (c <= n)
            {
                if (c == n)
                {
                    Console.WriteLine("Closest index is: " + index);
                    return true;
                }

                a = b;
                b = c;

                c = a + b;
                index++;
            }
            Console.WriteLine("Closest index is: " + (index-1));
            return false;
        }
    }
}
