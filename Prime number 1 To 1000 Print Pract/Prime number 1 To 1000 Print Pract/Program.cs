using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number_1_To_1000_Print_Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,count = 0;
            for (n = 1; n <= 1000; n++)
            {
                count = 0;

                for (i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write("{0} \t", n);
                }
            }
            Console.ReadLine();
        }      
    }
}
