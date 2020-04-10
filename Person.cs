using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Person
    {
        string Name;
        int Age;

        public Person(string person, int age)
        {
            Name = person;
            Age = age;
        }

        public void Getnameandage()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("+ The person has name : {0}", Name);
            Console.WriteLine("+ The person has age  : {0}", Age);
            Console.WriteLine("+++++++++++++++++++++++++++++");
        }
    }
}
