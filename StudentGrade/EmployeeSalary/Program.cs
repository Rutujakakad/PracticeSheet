// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{
    class Employee
    { //Q.20)Filter a list of employees based on certain criteria using lambda expressions, such as selecting all employees with a salary above a certain threshold.
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
               new Employee { Name = "Riya", Salary = 60000, Department = "HR" },
               new Employee { Name = "Tina", Salary = 45000, Department = "IT" },
               new Employee { Name = "Alex", Salary = 80000, Department = "Finance" },
               new Employee { Name = "John", Salary = 92000, Department = "IT" }
            };

            double salaryThreshold = 50000;


            var HighSalary = emp.Where(x => x.Salary > salaryThreshold).ToList();

            Console.WriteLine("Employees with salary above the threshold:");
            foreach (var employee in HighSalary)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}, Department: {employee.Department}");
            }


        }

       
        



    }
}
        