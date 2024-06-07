using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumstration_Switch_Case
{
    class Program
    {

        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            Days mydays = Days.Sunday;

            switch (mydays)
            {
                case Days.Sunday:
                    break;
                case Days.Monday:
                    break;
                case Days.Tuesday:
                    break;
                case Days.Wednesday:
                    break;
                case Days.Thursday: 
                    break;
                case Days.Friday:
                    break;
                case Days.Saturday:
                    break;
                default:
                    break;
            }
        }
    }
}
