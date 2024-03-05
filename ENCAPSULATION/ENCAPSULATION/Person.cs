using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCAPSULATION
{
    class Person
    {   

        string name;
        int age;

        public void setname(string name)
        {
            
            if(string.IsNullOrEmpty(name)== true)
            {
                Console.WriteLine("Name Field Is Mandatory !!!");
            }
            else
            {
                this.name = name;
            }
        }

        public void getname()
        {
            if (string.IsNullOrEmpty(name) == true)
            {
              
            }
            else
            {
                Console.WriteLine("Your Name Is : "+this.name);

            }
        }

        public void setage(int age)
        {

            if(age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Age Should Not Be Negative Or Zero !!!");   
            }
        }

        public void getage()
        {
            if(age > 0)
            {
                Console.WriteLine("Your Age Is : " + this.age);
            }
            else
            {
                

            }
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            p.setname("P.v.s");
            p.getname();
            p.setage(30);
            p.getage();

            Console.ReadLine();
        }
    }
}
