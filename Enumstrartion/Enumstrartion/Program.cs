

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumstrartion
{
    class Program
    {

     
        static void Main(string[] args)
        {
            //string[] members = (String[])Enum.GetNames(typeof(Days));

            //foreach(string week in members)
            //{
            //    Console.WriteLine(week);
            //}


            int[] values = (int[])Enum.GetValues(typeof(Days));

            foreach (int digit in values)
            {
                    Console.WriteLine(digit);
            }

            //Enum Conversion
            //Days MyDay = (Days)6;
            //Console.WriteLine(MyDay);

            //int value = (int)Days.Saturday;
            //Console.WriteLine(value);

            //Days Birthday = Days.Wednesday;
            //Console.WriteLine(Birthday);

            //Console.WriteLine(Days.Wednesday);

            //                         This Is Enumstration

            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("My Name IS Pragnesh");
            Console.ReadLine();
        }
    }
}
