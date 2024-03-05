using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Number_in_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            int n,rev=0,r;

            Console.Write("Enter Any Number =>");
            n=Convert.ToInt32(Console.ReadLine());

            while(n>0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }

            n = rev;

            while (n > 0)
            { 
                r = n % 10;

                switch (r)
                {
                    case 1:
                        {
                            Console.Write("One");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Two");
                            break;

                        }
                    case 3:
                        {
                            Console.Write("Three");
                            break;

                        }
                    case 4:
                        {
                            Console.Write("Four");
                            break;

                        }
                    case 5:
                        {
                            Console.Write("Five");
                            break;

                        }
                    case 6:
                        {
                            Console.Write("Six");
                            break;

                        }
                    case 7:
                        {
                            Console.Write("Seven");
                            break;

                        }
                    case 8:
                        {
                            Console.Write("Eight");
                            break;

                        }
                    case 9:
                        {
                            Console.Write("Nine");
                            break;

                        }
                    case 0:
                        {
                            Console.Write("Zero");
                            break;

                        }
                    default:
                        {
                            Console.Write("Not Availabale");
                            break;

                        }
                }
                n = n / 10;

            }
            Console.ReadLine();


        }
    }
}
