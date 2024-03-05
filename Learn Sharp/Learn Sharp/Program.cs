using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter First Name :");
            //string fname = Console.ReadLine();
            //Console.Write("Enter Last Name :");
            //string lname = Console.ReadLine();

            //Console.WriteLine("Your Name Is : {0} {1}", fname, lname); //Place Holder Message

            //Data Type Ni Range Jova Mate

            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------------------------------

            //   DateTime Format

            DateTime dt = DateTime.Now;
            //Console.WriteLine("{0:d}", dt);   //output =  23-02-2024(Short date)

            ////Console.WriteLine("{0:D}", dt); //output =  23 February 2024(Long date)

            //Console.WriteLine("{0:f}", dt);   //output =  23 February 2024 18:35(Full DateTime/Short Time)

            //Console.WriteLine("{0:F}", dt);   //output =  23 February 2024 18:36:24(Full DateTime/Long Time)

            //Console.WriteLine("{0:g}", dt);     //output =  23-02-2024 18:37(Genral DateTime(Short Time))

            //Console.WriteLine("{0:d} , {1:D}", dt,  dt);     //output =23-02-2024 , 23 February 2024

            //Console.WriteLine("{0:G}", dt);     //output =  23-02-2024 18:47:13 (Genral DateTime(Short Time))

            //Console.WriteLine("{0:m}", dt);     //output = 18:50(Month Day)

            //Console.WriteLine("{0:t}", dt);     //output =  23 February(Short time)

            //Console.WriteLine("{0:T}", dt);     //output =  18:50:47(Long time)

            //Console.WriteLine("{0:y}", dt);     //output =  February, 2024(Year Monyh Patern time)

            //Console.WriteLine("{0:ddd}", dt);     //output =Fri

            //Console.WriteLine("{0:dddd}", dt);     //output =Friday

            //Console.WriteLine("{0:ff}", dt);     //output =77(Secend Count Mate)

            //Console.WriteLine("{0:HH}", dt);     //output =18(24 hrs)

            //Console.WriteLine("{0:MM}", dt);     //output =02(Month 1 Yo 12)

            //Console.WriteLine("{0:MMM}", dt);     //output =Feb(oct,feb,mar,jul etc)

            //Console.WriteLine("{0:ss}", dt);     //output =05(Second 1 to 59)

            //Console.WriteLine("{0:HH:mm:ss:tt}", dt);     //output = 18:59:58:PM

            // Console.WriteLine("{0:dd-MM-yyyy}", dt);     //output = 23-02-2024



            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------------------------------

            //ternary Oprators ==> ? :

            //int a = 20;

            //string b = (a > 40) ? ("A Is Greter") : ("A Is Not Greter");



            //string name = Console.ReadLine();

            //if(name == "Pr")
            //{
            //    Console.WriteLine("Welcome");
            //}
            //else
            //{
            //    Console.WriteLine("By");
            //}

            // Console.WriteLine();

            //Console.Write("Enter UserName ==> ");
            //string username = Console.ReadLine();
            //Console.Write("Enter UserName ==> ");
            //string password = Console.ReadLine();



            //if (username == "pragnesh" && password == "123")
            //{
            //    Console.WriteLine("LogIn sucesss");
            //}
            //else
            //{
            //    Console.WriteLine("Incorect Username & Password");
            //}

            //If Else If


            //Console.Write("Enter Email Address =>");
            //string email = Console.ReadLine();

            //if(email == "Pragnesh")
            //{
            //    Console.Write("Enter Password =>");
            //    string password = Console.ReadLine();

            //    if (password == "Pragnesh123")
            //    {
            //        Console.WriteLine("Log In Successful");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Password");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Email Addres");
            //}


            ////Nested Switch Case

            //Console.Write("Enter Your pizza =");
            //string pizza = Console.ReadLine();

            //switch(pizza)
            //{
            //    case "Fajita":
                    
            //            Console.WriteLine("Selected Pizza Is Fajita Pizza");
            //             break;

            //    case "Margerita":

            //            Console.WriteLine("Selected Pizza Is Margerita Pizza");
            //             break;

            //    case "7-Chese":

            //        Console.WriteLine("Selected Pizza Is 7-Chese Pizza");
            //        break;

            //    case "Vegitable":

            //        Console.WriteLine("Enter Add Vegitable In Pizza");
            //        string veg = Console.ReadLine();

            //        switch(veg)
            //        {
            //            case "Onion":
            //                Console.WriteLine("Add In Pizza  extra Onion");
            //                break;
            //            case "Sweet Corn":
            //                Console.WriteLine("Add In Pizza  extra Sweet Corn");
            //                break;
            //            default:
            //                Console.WriteLine("Not Awailable!!!!!!!!!!!!!!!!");
            //                break;
            //        }
            //        break;
                  

            //    default:
            //        Console.WriteLine("Pizza Not Availabale Now !!!!!!!!!!!!!!!!!!!!!");
            //        break;

            //}




            Console.ReadLine();
        }
    }
}
