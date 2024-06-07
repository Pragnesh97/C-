using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_OverLoadding_And_OverRidding
{
    //Function OverRidding
    class animal
    {
        public  void  print()
        {
            Console.WriteLine("Animal");
        }
    }

    class dog:animal
    { 
       public  void print()
        {
            Console.WriteLine("Dog");
        }
  
    //// Function OverLoadding
    //class OverLoading
    //{
    //    int sum,a,b;
    //    float sub;
    //    void Count(int a,int b)
    //    {
    //        Console.WriteLine(a+b);
    //    }
    //    void Count(float a,float b)
    //    {
    //        Console.WriteLine(a+b);
    //    }

        static void Main(string[] args)
        {

            //Function OverRidding
            dog d = new dog();
            d.print();

            // Function OverLoadding
            // OverLoading p = new OverLoading();
            // p.Count(200, 300);    //int answer
            //p.Count(10.5f,20f);   // Float Answer

            Console.ReadLine();
        }
    }
}
