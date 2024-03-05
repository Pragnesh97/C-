using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Information
{
    class employeeinfo
    {
        protected int empid;
        protected String empname;
        protected double grosspay;
        double taxdeduction = 0.1;
        double netsalary;

        public employeeinfo(int eid, String ename, int egrosspay)
        {
            this.empid = eid;
            this.empname = ename;
            this.grosspay = egrosspay;

        }

        void calculatesalary()
        {
            if(grosspay>=30000)
            {
                netsalary = grosspay - (taxdeduction * grosspay);
                Console.WriteLine("Net Salary Is = " + netsalary);
            }
            else
            {
                netsalary = grosspay;
                Console.WriteLine("Net Salary Is = " + netsalary);
            }
        }

        public void showdetails()
        {
            Console.WriteLine("Employee Id = " + empid);
            Console.WriteLine("Employee Name = " + empname);
            this.calculatesalary();
        }

       
        static void Main(string[] args)
        {
            employeeinfo obj = new employeeinfo(001,"Pragnesh",58000);
            obj.showdetails();
            Console.ReadLine();


        }
    }
}
