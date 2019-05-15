namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public double Salary { get; private set; }


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
