using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
   class Students : Person
    {
        public Students(string person, int age, string studentsID, string email):
        base (person, age)
            {
                StudentsID = studentsID;
                Email = email;
            }

        public string StudentsID {get; set;}
        public string Email {get; set;}
        
    }
}
