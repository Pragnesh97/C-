
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Example_AtmPin
{
    class Bank
    {
        private int atmpin = 1234;

       public void setpin()
        {
            Console.Write("Enter Your Atm Pin : ");
            int userinput = int.Parse(Console.ReadLine());
            int count=0;

            while (true)
            {
       
                if (userinput==atmpin)
                {
                    Console.Write("------------------------------------------------\n\"Your Atm Pin Is Correct\".\"WELCOME To The Bank!\"\n------------------------------------------------");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("\nPin Is Incorect !!! Please Try Again");
                    
                    if (userinput != atmpin)
                    {
                        if (count <= 2)
                        {
                            Console.Write("\nEnter Your Atm Pin: ");
                            userinput = int.Parse(Console.ReadLine());
                            count++;

                        }
                        else
                        {
                            Console.WriteLine("\n------------------------------------------------------------\nDaily Limit Is excuseed \"Card Is BLocked\" Try Again Tomorow\n------------------------------------------------------------");
                            break;
                            
                        }

                        //else if (userinput == atmpin)
                        //{
                        //    Console.Write("----------------------------------\n\"Your Atm Pin Is Corect.WELCOME !\"\n----------------------------------");
                        //    break;
                        //}
                      
                    }                
                }
            }
        }

        static void Main(string[] args)
        {
            Bank p= new Bank();
            p.setpin();
            Console.ReadLine();
        }
    }
}

