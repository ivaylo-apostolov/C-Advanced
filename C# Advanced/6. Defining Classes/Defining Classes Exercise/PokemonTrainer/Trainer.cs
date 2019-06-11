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

        public void CheckElements(string command, Trainer trainer)
        {
            bool isFoundElement = false;

            foreach (var pokemon in trainer.Pokemons)
            {
                if (pokemon.Element == command)
                {
                    isFoundElement = true;
                }
            }

            if (isFoundElement)
            {
                trainer.NumberOfBadges++;
            }
            else
            {
                var listPokemonsToRemove = new List<Pokemon>();

                foreach (var pokemon in trainer.Pokemons)
                {
                    if (pokemon.Health > 10)
                    {
                        pokemon.Health -= 10;
                    }
                    else
                    {
                        listPokemonsToRemove.Add(pokemon);
                    }
                }

                foreach (var poke in listPokemonsToRemove)
                {
                    trainer.Pokemons.Remove(poke);
                }
            }

        }

        public override string ToString()
        {
            return $"{this.Name} {this.NumberOfBadges} {this.Pokemons.Count}";
        }

    }
}
