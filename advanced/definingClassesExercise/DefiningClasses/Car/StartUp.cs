using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {

            List<Trainer> trainers = new List<Trainer>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainerName = data[0];
                string pokemonName = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);
                Trainer findSameTrainer = trainers.Find(t => t.Name == trainerName);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonHealth, pokemonElement);
                if (findSameTrainer == null)
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    findSameTrainer.Pokemons.Add(pokemon);
                }


            }


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")  //•	"Fire" , •	"Water" , •	"Electricity"
            {
                Func<Trainer, string, bool> checkForBadge = (trainer, element) =>
                {
                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == element)
                        {
                            return true;
                        }
                    }

                    return false;
                };
                Func<Trainer, string, bool> checkForLoseHP = (trainer, element) =>
                {
                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == element)
                        {
                            return false;
                        }
                    }

                    return true;
                };


                List<Trainer> trainersWhichWinBadge = trainers.Where(t => checkForBadge(t, command)).ToList();
                List<Trainer> trainersWhichPokemonsLoseHP = trainers.Where(t => checkForLoseHP(t, command)).ToList();

                foreach (var trainer in trainersWhichWinBadge)
                {
                    trainer.numberOfBadges += 1;
                }

                foreach (var trainer in trainersWhichPokemonsLoseHP)
                {

                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;

                    }
                }

                RemoveZeroHp(trainers);

            }

            trainers = trainers.OrderByDescending(t => t.numberOfBadges).ToList();
            foreach (Trainer trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.numberOfBadges} {trainer.Pokemons.Count}");
            }



        }

        private static void RemoveZeroHp(List<Trainer> trainers)
        {
            foreach (Trainer trainer in trainers)
            {
                trainer.Pokemons.RemoveAll(p => p.Health <= 0);
            }
        }
    }
}

