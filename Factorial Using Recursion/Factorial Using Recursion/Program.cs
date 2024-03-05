using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Using_Recursion
{
    class Program
    {
        int n = 4;
        int fact = 1;
        public int factorial()
        {
            if (n == 0)
            {
                return 1;
            }
            fact = fact * n;
            n--;
            factorial();
            return fact;
        }
        public static void Main(string[] args)
        {
            int d;
            Program pv = new Program();
            d = pv.factorial();
            Console.WriteLine("Factorial Is =" + d);
            Console.ReadLine();
        }
    }
}


