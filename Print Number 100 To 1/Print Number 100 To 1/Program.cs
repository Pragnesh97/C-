using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Number_100_To_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=100,i;
            i = n;


            while(i>=1)
            {
                Console.Write(i + " " );
                i--;
            }
            Console.ReadLine();
        }
    }
}
