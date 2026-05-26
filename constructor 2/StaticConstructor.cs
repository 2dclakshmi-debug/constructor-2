using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_2
{
    class Student
    {
        public int sid;
        public string sname;
        static string Collegename;
        public Student(int sid, string sname)
        {
            this.sid = sid;
            this.sname = sname;
        }
        static Student()
        {
            Collegename = "JNTU";
        }
        public void StudentDisplay()
        {
            Console.WriteLine("Studeent id is :" + sid);
            Console.WriteLine("Student name is :"+sname);
        }
        public static void collegeDisplay()
        {
            Console.WriteLine("Collegename is :"+Collegename);
        }
    }
    internal class StaticConstructor
    {
        //static void Main(string[] args)
        //{
        //    Student obj = new Student(11, "Rani");
        //    obj.StudentDisplay();
        //    Student obj1 = new Student(12, "Tanmay");
        //    obj1.StudentDisplay();
        //    Student.collegeDisplay();
        //}
    }
}
