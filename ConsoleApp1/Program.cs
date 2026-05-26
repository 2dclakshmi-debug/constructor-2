using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyConstructor
{
    class student
    {
        public int sid;
        public string sname;
        public student(int Sid,string Sname)
        {
            sid = Sid;
            sname = Sname;
        }
        public student(student stu) 
        {
           sid=stu.sid;
            sname=stu.sname;
        }
        public void StudentDisplay()
        {
            Console.WriteLine("student id :" + sid);
            Console.WriteLine("student name :" + sname);
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    student obj = new student(11, "tanu");
        //    obj.StudentDisplay();
        //    student sobj=new student(obj);
        //    sobj.sid = 13;
        //    sobj.StudentDisplay();
        //}
    }
}
