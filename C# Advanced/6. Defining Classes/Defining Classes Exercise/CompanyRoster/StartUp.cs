using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            var listEmployee = new List<Employee>();
            var listDepartments = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                var name = tokens[0];
                double salary = double.Parse(tokens[1]);
                string position = tokens[2];
                string department = tokens[3];
                string email = null;
                string age = null;
                string temp = null;

                if (tokens.Length > 4 )
                {
                    temp = tokens[4];

                    if (Regex.IsMatch(temp, @"\d{1,3}"))
                    {
                        age = temp;
                    }
                    else if (Regex.IsMatch(temp, @"^[\w\d\.]{1,20}@[\w\d]{1,20}\.[\w]{2,6}$"))
                    {
                        email = temp;
                    }
                }
                if (tokens.Length > 5)
                {
                    temp = tokens[5];

                    if (Regex.IsMatch(temp, @"\d{1,3}"))
                    {
                        age = temp;
                    }
                    else if (Regex.IsMatch(temp, @"^[\w\d\.]{1,20}@[\w\d]{1,20}\.[\w]{2,6}$"))
                    {
                        email = temp;
                    }
                }

                if (age == null && email == null)
                {
                    Employee employee = new Employee(name, salary, position, department);
                    listEmployee.Add(employee);

                }
                else if (age != null && email == null)
                {
                    Employee employee = new Employee(name, salary, position, department, int.Parse(age));
                    listEmployee.Add(employee);
                }
                else if (age == null && email != null)
                {
                    Employee employee = new Employee(name, salary, position, department, email);
                    listEmployee.Add(employee);
                }
                else if (age != null && email != null)
                {
                    Employee employee = new Employee(name, salary, position, department, email, int.Parse(age));
                    listEmployee.Add(employee);
                }

                listDepartments.Add(department);
            }

            string topDepartment = string.Empty;
            double maxAverageSalary = 0;

            foreach (var department in listDepartments)
            {
                double salary = listEmployee.Where(e => e.Department == department).Select(e => e.Salary).Average();

                if (salary > maxAverageSalary)
                {
                    maxAverageSalary = salary;
                    topDepartment = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {topDepartment}");

            foreach (var employee in listEmployee.Where(e => e.Department == topDepartment)
                .OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
