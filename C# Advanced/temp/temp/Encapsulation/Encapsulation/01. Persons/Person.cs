using System;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length <= 3)
                {
                    Console.WriteLine("First name cannot contain fewer than 3 symbols!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length <= 3)
                {
                    Console.WriteLine("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 460)
                {
                    Console.WriteLine("Salary cannot be less than 460 leva!");
                }

                this.salary = value;
            }
        }


        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }

        public void SalaryIncrease(Person person, int increase)
        {
            if (person.Age < 30)
            {
                person.Salary += person.Salary * increase / 100;
            }
            else if (this.Age >= 30)
            {
                person.Salary += person.Salary * increase / 100;
            }
        }
    }
}
