using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count=0;


            Console.WriteLine("Enter Any Number =>");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i<= n; i++)
            {
                if(n%i==0)
                {
                    count++;
                }
               
            }
            if(count==2)
            {
                Console.WriteLine("Prime Number");
            }
            else
                Console.WriteLine("Not Prime Number");

            Console.ReadLine();
        }
    }
}

