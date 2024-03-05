
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_in_Method
{
    class Program
    {
        int n1=200,n2=100,result;
        
        void add()
        {
            result = n1 + n2;
            Console.WriteLine("Sum Result Is = " + result);
        }
        void subtract()
        {
            result = n1 - n2;
            Console.WriteLine("Subtract Result Is = " + result);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.add();
            obj.subtract();
            Console.ReadLine();

        }
    }
}
