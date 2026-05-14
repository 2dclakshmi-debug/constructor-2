using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_2
{
    class MyClass
    {
        int sid;
        string name;
        int age;
     public MyClass(int stdid,string stdname,int stdage)
        {
            sid = stdid;
            name = stdname;
            age = stdage;

        }
        public void display()
        {
            //Console.WriteLine("Student id :" + sid);
            //Console.WriteLine("Student Name :" + name);
            //Console.WriteLine("Student Age :"+age);
           

            //Console.WriteLine("****************************************************");
            Console.WriteLine(sid + "               " + name + "             " + age);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                MyClass obj = new MyClass(11,"Ravi",20);
                obj.display();
                MyClass[] objs=new MyClass[3];
                objs[0] = new MyClass(2, "Rani", 21);
                objs[1] = new MyClass(3, "Rahul", 22);
                objs[2] = new MyClass(4, "Raju", 23);
                Console.WriteLine("Student details :");
                Console.WriteLine("-----------------");
                Console.WriteLine("Studentid" + "    " + "Studentname" + "     " + "Studentage");
                for (int i = 0; i < objs.Length; i++)
                {
                   
                    objs[i].display();
                }

            }
        }
    }
}
