using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_2
{
    class Employees
    {
        int Eid;
        string Ename;
        double Esal;
        static string CompanyName;
        public Employees(int eid, string ename, double esal)
        {
            Eid = eid;
            Ename = ename;
            Esal = esal;
        }
        static Employees()
        {
            CompanyName = "TCS";
        }
        public void EmployeeDisplay()
        {
            Console.WriteLine("Employee id : " + Eid);
            Console.WriteLine("Employee name : " + Ename);
          
        }
        public static void CompanyDisplay()
        {
            Console.WriteLine("Employee company : " + CompanyName);
        }
        public void salaryHike()
        {
            Esal += Esal * 10 / 100;
            Console.WriteLine("Employee sal : " + Esal);
        }

    }
    internal class Example2
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees(11, "Lakshmi", 100000);
             emp.EmployeeDisplay();
            emp.salaryHike();
            Employees emp1 = new Employees(21, "Rani", 100000);
            emp1.EmployeeDisplay();
            emp1.salaryHike();
            Employees.CompanyDisplay();
        
        
        }
        
    }
}
