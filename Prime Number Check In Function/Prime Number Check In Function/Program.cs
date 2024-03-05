using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Check_In_Function
{
    class Program
    {
         static int count = 0;
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Any Number=>");
            n = int.Parse(Console.ReadLine());

            count = PrimeWithReturn(n);

            if (count == 2)
            {
                Console.WriteLine("Prime");
            }
            else
                Console.WriteLine("Not Prime");

            PrimeWithoutReturn(n);
            Console.ReadLine();
        }
        private static int PrimeWithReturn(int xyz)
        {
            count = 0;

            for (int i = 1; i <= xyz / 2; i++)
            {
                if (xyz % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
        private static void PrimeWithoutReturn(int v)
        {
            count = 0;
            for (int i = 1; i <= v / 2; i++)
            {
                if (v % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime");
            }
            else
                Console.WriteLine("Not Prime");
        }
    }
}
