using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Method_First
{
    public class Calculator
    {
        int num1, num2, result;
        public void add()
        {
          

            Console.Write("Enter Num 1 Value for Add=>");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Num 2 Value for Add=>");
            num2 = int.Parse(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("\t" + result);

        }
        void sub()
        {
            Console.Write("Enter Num 1 Value for sub=>");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Num 2 Value for sub=>");
            num2 = int.Parse(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine("\t" + result);

        }


        public  static void Main(string[] args)
        {
            Calculator pv =new Calculator();
            pv.add();
            pv.sub();

            Console.ReadLine();
        }
    }
}
