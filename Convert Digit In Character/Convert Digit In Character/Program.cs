using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Digit_In_Character
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Number ==> ");

            string userent = Console.ReadLine();
            int digit = userent.Trim().Length;
           int num = int.Parse(userent);
            Console.Write("Number is " + num);

            string[] digitwords = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            int[] n = new int[digit];
            Console.ReadLine();
        }
    }
}
