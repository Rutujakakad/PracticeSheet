using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualClassroom
{
    internal class Student : Person
    {
        public string Grades {  get; set; }
        public Student(string name, string email) : base(name, email) { }

        public virtual void DisplayInfo()//if override it is giving error
        {
            base.DisplayInfo();
            Console.WriteLine("Enrolled for courese:");
            foreach (var grade in Grades)
            {
                Console.WriteLine($"Course: {grade}, Grade: {grade}");
            }
        }
    }
}
