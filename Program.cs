using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Nero", 20);
            person.Getnameandage();

            Teacher teacher = new Teacher("Zidane", 35, "1104", "Programming");
            teacher.Getnameandage();

            Students students = new Students("Frank", 18, "1911", "fr18@students.amikom.ac.id");
            students.Getnameandage();

            Console.ReadKey();
        }
    }
}
