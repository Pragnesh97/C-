using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_Argument_With_Return_Factorial_Find
{

    class Program
    {
        void input()
        {
             
            //Console.WriteLine("Without Argument Without Return sum Find Is =>" + result);
            //Console.ReadLine();
            
        }
       
         
            //  No Argument With Return sum Find

        int sum()
        {
            int result, a, b;
            Console.Write("Enter Number A=>");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter Number B=>");
            b = int.Parse(Console.ReadLine());

            result = a + b;
            return result;
        }

        void sum0()
        {
            //  No Argument No Return sum Find

            int a, b;
            Console.Write("Enter Number A=>");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter Number B=>");
            b = int.Parse(Console.ReadLine());

           int result = a + b;
            // Console.WriteLine("Without Argument Without Return sum Find Is =>" + result);
            //Console.ReadLine();
           

        }


        void sum1(int x,int y)
        {
            //  With Arrgument no Return

            int result;

            result = x + y;
            // Console.WriteLine("With Arrgument no Return is="+result);
           
        }
        public int sum2(int x,int y)
        {
              //  With Arrgument With Return

            int result;

            result = x + y;

            return result;
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            // No Argument With Return sum Find 

            // int c= p.sum();
            // Console.WriteLine("No Argument With Return sum Find is => "+c);

            // No Argument No Return sum Find
            //p.sum0();

            // With Arrgument With Return
            //int d=p.sum2(10,20);
            //Console.WriteLine("With Arrgument With Return Sum =>" + d);
            //Console.ReadLine();

            //  With Arrgument no Return
            p.sum1(1000,2000);

            Console.ReadLine();    

        }
    }
}
