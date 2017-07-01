namespace _11.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private const int PokemonHealtLossDueToMissingElement = 10;

        public static void Main()
        {
            var trainers = GetTrainers();
            PlayWithElements(trainers);
            PrintTrainers(trainers);
        }

        private static void PrintTrainers(Queue<Trainer> trainers)
        {
            Console.WriteLine(string.Join(Environment.NewLine, trainers
                .OrderByDescending(t => t.Badges)
                .Select(t => $"{t.Name} {t.Badges} {t.Pokemons.Count}")));
        }

        private static void PlayWithElements(Queue<Trainer> trainers)
        {
            var element = Console.ReadLine().Trim();

            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Where(p => p.Element == element).FirstOrDefault() == null)
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.ReduceHealth();
                        }

                        trainer.ClearDeadPokemons();
                    }
                    else
                    {
                        trainer.AddABadge();
                    }
                }

                element = Console.ReadLine().Trim();
            }
        }

        private static Queue<Trainer> GetTrainers()
        {
            var trainers = new Queue<Trainer>();
            var playerData = Console.ReadLine().Split().Select(x => x.Trim()).ToArray();

            while (playerData[0] != "Tournament")
            {

                var trainerName = playerData[0];
                var pokemonName = playerData[1];
                var element = playerData[2];
                var health = int.Parse(playerData[3]);
                var currentPokemon = new Pokemon(pokemonName, element, health);
                var currentTrainer = trainers.Where(t => t.Name == trainerName).FirstOrDefault();

                if (currentTrainer == null)
                {
                    currentTrainer = new Trainer(trainerName);
                    currentTrainer.Pokemons.Push(currentPokemon);
                    trainers.Enqueue(currentTrainer);
                }
                else
                {
                    currentTrainer.Pokemons.Push(currentPokemon);
                }

                playerData = Console.ReadLine().Split().Select(x => x.Trim()).ToArray();
            }

            return trainers;
        }
    }
}
