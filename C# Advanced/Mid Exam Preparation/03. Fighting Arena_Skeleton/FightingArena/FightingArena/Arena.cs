using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public string Name { get; set; }

        public int Count
        {
            get
            {
                return gladiators.Count;
            }
        }

        public Arena(string name)
        {
            this.gladiators = new List<Gladiator>();
            this.Name = name;
        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiator = gladiators.Where(g => g.Name == name).FirstOrDefault();

            gladiators.Remove(gladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator gladiator = gladiators.OrderByDescending(g => g.GetStatPower()).FirstOrDefault();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator gladiator = gladiators.OrderByDescending(g => g.GetWeaponPower()).FirstOrDefault();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator gladiator = gladiators.OrderByDescending(g => g.GetTotalPower()).FirstOrDefault();

            return gladiator;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Count} gladiators are participating.";
        }
    }
}
