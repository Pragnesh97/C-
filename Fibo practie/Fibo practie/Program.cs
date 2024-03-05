using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo_practie
{
    class Program
    {
         
        static void Main(string[] args)
        {

            int n,a=0,b=1,i,c;

            Console.WriteLine("Enter Any Number==>");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}      {1}",a,b);


            for (i=2;i<=n;i++)
            {
                c = a + b;
                Console.Write("\t{0} \t", c);
                a = b;
                b = c;
            }




            Console.ReadKey();
        }
    }
}

