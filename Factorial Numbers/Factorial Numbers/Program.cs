using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int n, i, fact = 1;

            Console.Write("Enter Numbers ==> ");
            n=Convert.ToInt32(Console.ReadLine());

            for(i=n;i>=1;i--)
            {
                fact = fact * i;
            }

            Console.WriteLine(n + " Factorial Is => " + fact);


            Console.ReadLine();

        }
    }
}