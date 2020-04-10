using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Teacher : Person
    {
        public Teacher(string person, int age, string teacherID, string subjek):
        base (person , age)
            {
                TeacherID = teacherID;
                Subjek = subjek;
            }

        public string TeacherID {get; set;}
        public string Subjek {get; set;}
    }
}
