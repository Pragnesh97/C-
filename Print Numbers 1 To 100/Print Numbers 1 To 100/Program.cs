using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Numbers_1_To_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1,i;
            i=n;
            while(i<=100)
            {
                Console.Write(i + " " );
                i++;
            }

            Console.ReadLine();

        }
    }
}
