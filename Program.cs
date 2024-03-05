using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferari v = new Ferari();
            v.price = 510000;
            v.model= "500";
            v.Colour= "Yellow";
            v.mnumber = "320";
            v.speed = "30 Km/s";
            v.PrintInfo();
            v.Printspeed();
            v.printmodel();

            Console.ReadLine();

        }
    }

    class Maruti
    {
        public int price;
        public string model;
        public string Colour;
        public void PrintInfo()
        {
            Console.WriteLine("Maruti Car Price Is => " + price);
            Console.WriteLine("Maruti Car Model Is => "  + model);
            Console.WriteLine("Maruti Car Colour Is => "  + Colour);
        }
    }

    class Ferari:Maruti
    {
        public string speed;
        public void Printspeed()
        {
            Console.WriteLine("Ferari Car Speed Is => " + speed);
        }
    }

    class Bmw:Ferari
    {
        public string mnumber;
        public void printmodel()
        {
            Console.WriteLine("BMW Model Number IS => "+ mnumber);

        }
    }
}
