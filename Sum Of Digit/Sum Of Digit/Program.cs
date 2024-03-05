using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0,r;

            Console.Write("Enter Numbers==> ");
                n = Convert.ToInt32(Console.ReadLine());

            while(n>0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }

            
                Console.WriteLine(" Sum Of Digit " + sum);

            Console.ReadLine();
        }

    }
}
