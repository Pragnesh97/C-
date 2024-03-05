using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Single Inheritance
    class Program
    {
       public static void Main(string[] args)
        {
            maruti pv = new maruti();
            pv.model = "Swift";
            pv.colour = "Black";
            pv.price = 200000;
            pv.milege = 20.3f;
            pv.PrintCarInfo();
            pv.printmilege();

            Console.ReadLine();

        }

    }

    class car
    {
        public string model;
        public string colour;
        public  int price;

        public void PrintCarInfo()
        {
            Console.WriteLine("Model Is =" + model);
            Console.WriteLine("Colur Is =" + colour);
            Console.WriteLine("Price Is =" + price);    
        }
    }

    class maruti:car
    {
        public float milege;
        public void printmilege()
        {
            Console.WriteLine("Milege Is =" + milege);
        }
    }
}
