using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i, fact = 1;

            Console.WriteLine("Enter Any Number =>");
            n = int.Parse(Console.ReadLine());

            for(i=1;i<=n;i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);

            Console.ReadLine();
        }
    }
}
