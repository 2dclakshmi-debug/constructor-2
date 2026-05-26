using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
      public int age { get; set; }
        public string name { get; set; }
        public Person(int Age,string Name)
        {
            age = Age;
            name = Name;
        }
        public Person(Person previosperson)
        {
            age = previosperson.age;
            name = previosperson.name;
        }
        public void display()
        {
            Console.WriteLine("person age :" + age);
            Console.WriteLine("person name :" + name);
        }
    }

    internal class Example1
    {
        static void Main(string[] args)
        {
            Person person = new Person(19, "Raju");
            person.display();

            Person obj=new Person(person);
            obj.age = 32;
            obj.name = "Hari";
            obj.display();
            Console.WriteLine("press any key for closing");
            Console.ReadKey();

        }
    }
}
