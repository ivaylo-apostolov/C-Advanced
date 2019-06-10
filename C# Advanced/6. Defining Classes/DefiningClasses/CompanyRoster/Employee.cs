using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyRoster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public string Department { get => department; set => department = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }

        public Employee()
        {
            this.Email = "n/a";
            this.Age = -1;            
        }

        public Employee(string name, double salary, string position, string department)
            : this()
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
        }

        public Employee(string name, double salary, string position, string department, string email)
            : this(name, salary, position, department)
        {
            this.Email = email;
        }

        public Employee(string name, double salary, string position, string department, int age)
            : this(name, salary, position, department)
        {
            this.Age = age;
        }
    }
}
