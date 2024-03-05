using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_The_Element_Of_The_Following_List_Using_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j=10;

            for(i=1;i<=j;i++)
            {
                Console.Write( i*i  + "\t");
            }

            Console.ReadLine();
        }
    }
}
