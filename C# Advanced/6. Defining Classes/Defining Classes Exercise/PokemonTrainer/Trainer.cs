using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;

        private int numberOfBadges;

        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get => name; set => name = value; }

        public int NumberOfBadges { get => numberOfBadges; set => numberOfBadges = value; }

        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }

        public void AddPokemon(Trainer trainer, Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }
        
    }
}
