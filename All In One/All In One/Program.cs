using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_In_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nValue Swap Program ==>\n");


            int a = 10, b = 20, c;

            Console.WriteLine("A = 10 ");
            Console.WriteLine("B = 20 ");

            Console.WriteLine("\nAfter Swap \n");

              c = a;        //10
              a = b;        //20
              b = c;        //10

            Console.WriteLine("A = " + a + " \nB = " + b);
//----------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------

           Console.Write("\nPalindrom Numbers Print 1 To 1000 Program ==>");

            int i, rev, r,n;
            for (i = 0; i < 1000; i++)
            {
                n = i;
                rev = 0;


                while (n != 0)
                {
                    r = n % 10;
                    rev = rev * 10 + r;
                    n = n / 10;

                    if (i == rev)
                    {
                        Console.Write("\t" + rev);
                    }
                }
            }
//--------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------

           Console.Write("\n\nArmstrong Numbers Print 1 To 1000 Program =>");

            int e, f, g, sum;
            for (e = 0; e < 1000; e++)
            {
                f = e;
                sum = 0;

                while (f != 0)
                {
                    g = f % 10;
                    sum = sum + (g * g * g);
                    f = f / 10;

                    if (e == sum)
                    {
                        Console.Write("\t" + e);
                    }
                }
            }







           Console.ReadLine();
        }
    }
}
