using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Check_In_Method
{
    class Program
    {

        int n;
        void input()
        {
            Console.Write("Enter Any Number=>");
            n = int.Parse(Console.ReadLine());

        }
        void prime_check()
        {
            int  i, count = 0;
           
            for (i = 1; i <=n; i++)
            {
                if(n % i == 0)
                {
                    count++;
                    
                   
                }
            }
                 if (count==2)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");

                }
            
        }
        public static void Main(string[] args)
        {
            Program pv = new Program();
            pv.input();
            pv.prime_check();

            Console.ReadLine();
        }
    }
}
