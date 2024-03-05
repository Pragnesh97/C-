using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class car
    {
        string modelname;
        int caryear;
        public car(string model,int year)
        {
            caryear = year;
            modelname = model;

        }
        static void Main(string[] args)
        {
            car obj = new car("Mustang",1997);
            Console.WriteLine("Model ="+obj.modelname);
            Console.WriteLine("year =" + obj.caryear);


            Console.ReadLine();
        }
    }
}
