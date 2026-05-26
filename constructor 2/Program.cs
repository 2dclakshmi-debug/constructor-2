using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_2
{
    class Employee
    {
        int Empid;
        string Empname;
        double Salary;
     public Employee()
        {
            Empid = 11;
            Empname = "Raju";
            Salary = 10000;
        }
        public void SalaryHike()
        {
            Console.WriteLine("Employee Detailss:");
            Console.WriteLine("------------------");
            Console.WriteLine("Empid" + "     " + "Empname" + "        " + "Empsalary");
            Console.WriteLine(Empid + "          " + Empname + "          " + Salary);
            int Hike = 10;
            Salary = Salary + Salary * Hike/ 100;
            Console.WriteLine("                                  ");
            Console.WriteLine("Employee salary with hike:" + Salary);
            
        }
        internal class Program
        {
            //static void Main(string[] args)
            //{
            //   Employee emp = new Employee();
            //    emp.SalaryHike();
            //    Console.ReadLine();
            //}
           
            
        }
        
    }

}
