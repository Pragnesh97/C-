using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Avarge_Calculate
{
    class Avarage
    {
        float startkm,endkm,liter;
        float Petrolprice, bikeavarage, travel;
        float literin, kilometer,onekm;

        //Total Km ANd Bike Avarge Calculate Karva Mate
        //km + Liter
        public void calculate()
        {
            Console.Write("Enter Start Kilometer : ");
            startkm = float.Parse(Console.ReadLine());
            Console.Write("Enter End Kilometer : ");
            endkm = float.Parse(Console.ReadLine());
            Console.Write("Enter Fuel In Tank In Liter : ");
            liter = float.Parse(Console.ReadLine());

            float total = endkm - startkm;
            float km = total / liter;

            Console.WriteLine("\n---------------------------------------");

            Console.WriteLine("Total KiloMeter Is : " + total);

            Console.WriteLine("---------------------------------------\nYour Bike Avarge is : " + km);

            Console.WriteLine("---------------------------------------\n");
        }

        //______ km mate atla _____ nu petrol Puravvau pade teni mate
        //petrolPrice + Bike/Car Average + Ketla Km Javanu Che E a 3 Vastu Joiye.

        void petrolcost()
        {
            Console.Write("Enter Petrol Peice : ");
            Petrolprice = float.Parse(Console.ReadLine());
            Console.Write("Enter Bike Avarage : ");
            bikeavarage = float.Parse(Console.ReadLine());
            Console.Write("Enter You Travel In Distance : ");
            travel = float.Parse(Console.ReadLine());

            float onekmprice = Petrolprice / bikeavarage;

            float totalpetrolarchive = onekmprice*travel;

            Console.WriteLine("\n---------------------------------------");


            Console.WriteLine("{0} KiloMeter Mate {1} Rs Petrol Joiye ",travel,totalpetrolarchive);

            Console.WriteLine("---------------------------------------\n");


        }


        void average()
        {

            //only Bike Avarage
            Console.Write("Enter Liter In Tank : ");
            literin = float.Parse(Console.ReadLine());
            Console.Write("Enter Run Kilometer : ");
            kilometer = float.Parse(Console.ReadLine());

            travel = kilometer * 1 / literin;


            Console.WriteLine("\n---------------------------------------");

            Console.WriteLine("Your Bike Avarage IS : " + travel);

            Console.WriteLine("---------------------------------------");
        }

        static void Main(string[] args)
        {
            Avarage bike = new Avarage();
          //  bike.calculate(); //Total Km ANd Bike Avarge Calculate Karva Mate
            bike.petrolcost();//___atla___ km mate Ketla _rs____ nu petrol Puravvau pade teni mate
          //  bike.average();//only Bike Avarage

            Console.ReadLine();
        }
    }
}
