using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Object
{

    //Learning Never End Youtube

    class student
    {
        int rollnumber;
        string name;
        int age;
        int std;

        void setstudent(int srollno,string sname,int sage,int sstd)
        {
            this.rollnumber = srollno;
            this.name = sname;
            this.age = sage;
            this.std = sstd;
        }

        void getstudent()
        {
            Console.WriteLine("Roll Number Is = " + this.rollnumber);
            Console.WriteLine("Student Name Is = " + this.name);
            Console.WriteLine("Age  Is = " + this.age);
            Console.WriteLine("Class Is = " + this.std);

        }

        static void Main(string[] args)
        {
            student ob = new student();
            ob.setstudent(007,"Kaushik",22,14);
            ob.getstudent();

            Console.WriteLine("\n==========================\n");

            student op = new student();
            op.setstudent(008,"Pragnesh", 24, 12);
            op.getstudent();
            Console.ReadLine();
            

            
        }
    }
}
