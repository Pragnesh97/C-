using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            maruti pv = new maruti();
            Console.Write("Model Name =");
            pv.model = Console.ReadLine();
            Console.Write("Colour Name =");
            pv.colour = Console.ReadLine();
            Console.Write("Price =");
            pv.price = int.Parse(Console.ReadLine());
            Console.Write("Milege is=");
            pv.milege = float.Parse(Console.ReadLine());
            pv.PrintCarInfo();
            pv.printmilege();
            Console.Write("Speed=");
            pv.speed = int.Parse(Console.ReadLine());
            pv.printspeed();

            Console.ReadLine();

        }
    }


        class car
        {
            public string model;
            public string colour;
            public int price;

            public void PrintCarInfo()
            {
                Console.WriteLine("Model Is =" + model);
                Console.WriteLine("Colur Is =" + colour);
                Console.WriteLine("Price Is =" + price);
            }
        }

    class ferari:car
    {
        public int speed;

        public void printspeed()
        {
            Console.WriteLine("Speed is => " + speed);
        }
    }
        class maruti : ferari
        {
            public float milege;
            public void printmilege()
            {
                Console.WriteLine("Milege Is =" + milege);
            }
        }
    
}
