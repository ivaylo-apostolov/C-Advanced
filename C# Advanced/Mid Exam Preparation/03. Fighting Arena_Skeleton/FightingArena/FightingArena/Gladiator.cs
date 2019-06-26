using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            return GetStatPower() + GetWeaponPower();
        }

        public int GetWeaponPower()
        {
            int sum = Weapon.Size + Weapon.Solidity + Weapon.Sharpness;

            return sum;
        }

        public int GetStatPower()
        {
            int sum = Stat.Strength + Stat.Flexibility + Stat.Agility + Stat.Skills + Stat.Intelligence;

            return sum;
        }

        public override string ToString()
        {
            return $"{this.Name} - {GetTotalPower()}" +
                Environment.NewLine +
                $"  Weapon Power: {GetWeaponPower()}" +
                Environment.NewLine +
                $"  Stat Power: {GetWeaponPower()}";

        }
    }
}
