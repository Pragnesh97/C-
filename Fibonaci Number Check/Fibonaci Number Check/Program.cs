using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Fibonacci

            //Console.Write("Enter Number ==>  ");
            //int d = Convert.ToInt32(Console.ReadLine());
            //int a = 0, b = 1, c;
            //Console.Write(a + " " + b + " ");
            //c = a + b;
            //Console.Write(c);
            //for (int i = 2; i < d; i++)
            //{
            //    a = b;
            //    b = c;
            //    c = a + b;
            //    Console.Write(" " + c + " ");

            //}
            #endregion

            #region Swap Two number
            //int c;

            //Console.WriteLine("Enter Two Numbers ==> ");

            //Console.Write(" A Value=> ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" b Value=> ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //c = a;
            //a = b;
            //b = c;

            //Console.Write("a =" + a + " \t b = " + b);


            #endregion

            #region Prime or nt

            //int a, b;

            //Console.WriteLine("Enter Any Numbers ==> ");

            //Console.Write(" A Value=> ");
            //a = Convert.ToInt32(Console.ReadLine());


            //b = a / 2;
            //int prime = 0;
            //for (int i = 2; i < b; i++)
            //{
            //    if (a % i == 0)
            //    {
            //        prime = 0;
            //    }
            //    else
            //    {
            //        prime = 1;
            //    }

            //}
            //if (prime == 1)
            //    Console.WriteLine("Prime");
            //else
            //    Console.WriteLine("Not Prime");


            #endregion

            int a, b, prime = 0;
            Console.WriteLine("Enter Value = ");

            Console.Write("A = ");
            a = Convert.ToInt32(Console.ReadLine());

            b = a / 2;

            for (int i = 2; i < b; i++)
            {
                if (i % a == 0)
                {

                    prime = 0;
                    break;

                }
                else
                {

                    prime = 1;
                }
            }

            if (prime == 0)
            {
                Console.WriteLine("Not Prime");
            }
            else

                Console.WriteLine("Prime");


            Console.ReadLine();

        }
    }
}
