using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
     public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;
            var pokemons = new List<Pokemon>();
            var names = new HashSet<Trainer>();
            var dict = new Dictionary<string, Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                var tokens = input
                    .Split();

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                pokemons.Add(pokemon);

                if (!dict.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    names.Add(trainer);
                    dict[trainerName] = trainer;
                }

                dict[trainerName].AddPokemon(dict[trainerName], pokemon);
            }

            string input2 = string.Empty;

            while ((input2 = Console.ReadLine()) != "End")
            {
                foreach (var trainer in names)
                {
                    trainer.CheckElements(input2, trainer);
                }
            }

            foreach (var trainer in names.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine(trainer.ToString());
            }
        }
    }
}
