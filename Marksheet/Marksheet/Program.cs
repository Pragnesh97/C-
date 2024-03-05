using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name =>");
            string name = Console.ReadLine();
            Console.Write("Enter Your Roll Number =>");
            string roll = Console.ReadLine();
            Console.Write("Enter Your Class =>");
            string Std = Console.ReadLine();
            Console.Write("Enter Your Hindi Marks =>");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Gujrati Marks =>");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Maths Marks =>");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your English Marks =>");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Physics Marks =>");
            int p = Convert.ToInt32(Console.ReadLine());


            int obt = h + g + m + e + p;

            int per = obt * 100 / 500;

            Console.Write("\n\nObtained Marks Is => {0} \n",obt);

            Console.Write("\n\nPercentage Is => {0}", per);

            //Garde
            Console.WriteLine("\n \n");

            if(per > 90)
            {
                Console.WriteLine("A1 Grade");
            }
            else if (per > 80)
            {
                Console.WriteLine("A Grade");
            }
            else if (per > 70)
            {
                Console.WriteLine("B Grade");
            }
            else if (per > 60)
            {
                Console.WriteLine("C Grade");
            }
            else if (per > 50)
            {
                Console.WriteLine("D Grade");
            }
            else if (per > 40)
            {
                Console.WriteLine("E Grade");
            }
            else
            {
                Console.WriteLine("Fail ");
            }


            //Remark
            Console.WriteLine("\n");


            if (per > 90)
            {
                Console.WriteLine("Remark :Excellent");
            }
            else if (per > 80)
            {
                Console.WriteLine("Remark :Very Good");
            }
            else if (per > 70)
            {
                Console.WriteLine("Remark :Good");
            }
            else if (per > 60)
            {
                Console.WriteLine("Remark :Fair");
            }
            else if (per > 50)
            {
                Console.WriteLine("Remark :Poor");
            }
            else if (per > 40)
            {
                Console.WriteLine("Remark :Need Lots Of Imperovment");
            }
            else
            {
                Console.WriteLine("Bring to PArents Tomorrow");
            }
            //Count Subject Fail
            Console.WriteLine("");
            int suplly = 0;

            if(h < 33)
            {
                suplly++;
            }
            if (g < 33)
            {
                suplly++;
            }
            if (m < 33)
            {
                suplly++;
            }
            if (e < 33)
            {
                suplly++;
            }

            if (p < 33)
            {
                suplly++;
            }


            Console.WriteLine("{0} Is Failed In {1} Subjects", name, suplly);


            Console.ReadLine();

        }
    }
}
