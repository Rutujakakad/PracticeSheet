using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualClassroom
{
    internal class Teacher : Person
    {
        public int Courses {  get; set; }
        public Teacher(string name, string email) : base(name, email) { }


    }
}
