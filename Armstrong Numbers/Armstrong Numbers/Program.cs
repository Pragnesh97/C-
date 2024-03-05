using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp, sum = 0, r;
            Console.Write("Enter Any Numbers ==> ");
                n = Convert.ToInt32(Console.ReadLine());

            temp = n;

            while(n>0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine(" User Enter " + temp + " Is Armstrong");
            }
            else
            {
                Console.WriteLine(" User Enter " + temp + " Is Not Armstrong");

            }
            Console.ReadLine();
        }
    }
}
