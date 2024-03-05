using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_The_Multiplication_Table_Of_A_Numbers_N
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i = 1;

            Console.WriteLine("Enter Any Numbers ==>");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(" \n ");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} * {1} = {2} \n ", n, i, n * i);
            }
            Console.ReadLine();
        }
    }
}
