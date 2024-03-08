
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overridding
{
    class Enimal
    {
        public virtual void eat()
        {
            Console.WriteLine("Enimal Eating");
        }
    }

    class dog:Enimal
    {
        public override void  eat()
        {
            Console.WriteLine("Dog Eating");
        }
    
        static void Main(string[] args)
        {
            dog p = new dog();
            p.eat();

            Console.ReadLine();
        }
    }
}
