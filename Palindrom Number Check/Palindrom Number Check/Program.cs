using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int rev = 0,temp;
            Console.Write("Enter Any Numbers => ");
            int n = Convert.ToInt32(Console.ReadLine());

            temp = n;
            while(temp>0)
            {
                int r = temp % 10;
                rev = (rev * 10) + r;
                temp = temp / 10;
            }
            if(n==rev)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not  Palindrom");
            }
            Console.ReadLine();
        }
    }
}
