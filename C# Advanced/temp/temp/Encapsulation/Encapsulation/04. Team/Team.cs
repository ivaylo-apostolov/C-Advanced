using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Team
{
    public class Team
    {
        private string team;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string team)
        {
            this.team = team;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public List<Person> FirstTeam
        {
            get
            {
                return this.firstTeam;
            }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam.AsReadOnly();
            }
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
    }
}
