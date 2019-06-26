using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.data = new List<Astronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Astronaut astronaut)
        {
            if (data.Count < this.Capacity)
            {
                data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            Astronaut astronaut = data.Where(a => a.Name == name).FirstOrDefault();

            if (astronaut != null)
            {
                data.Remove(astronaut);
                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut astronaut = data.OrderByDescending(a => a.Age).FirstOrDefault();

            return astronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = data.Where(a => a.Name == name).FirstOrDefault();

            return astronaut;
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var astrounaut in data)
            {
                sb.AppendLine(astrounaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
