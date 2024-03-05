using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Pract
{
    class Program
    {
        static void Main(string[] args)
        
             



            int  i, rev = 0,n, r;

            Console.WriteLine("Enter Number=>");
             n = int.Parse(Console.ReadLine());

            i = n;

            while (n != 0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
                if(i==rev)
                
                    Console.WriteLine("Palindrom");
                
                else
                    Console.WriteLine("Not Palindrom");
            

            Console.ReadLine();
        }
    }
}
