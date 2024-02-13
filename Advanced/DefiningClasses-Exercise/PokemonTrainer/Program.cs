namespace PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string trainerInput = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (trainerInput != "Tournament")
            {
                string[] trainerData = trainerInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerData[0];
                string pokemonName = trainerData[1];
                string pokemonElement = trainerData[2];
                int pokemonHealth = int.Parse(trainerData[3]);
                
                Pokemon pokemon = new Pokemon();
                pokemon.Name = pokemonName;
                pokemon.Element = pokemonElement;
                pokemon.Health = pokemonHealth;

                if (!trainers.Any(x => x.Name == trainerName))
                {
                    Trainer trainer = new Trainer();
                    trainer.Name = trainerName;
                    trainer.PokemonList.Add(pokemon);
                    
                    trainers.Add(trainer);
                }
                else
                {
                    int indexOf = trainers.FindIndex(x => x.Name == trainerName);
                    trainers[indexOf].PokemonList.Add(pokemon);
                }


                trainerInput = Console.ReadLine();
            }

            string elementCommand = Console.ReadLine();

            while (elementCommand != "End") 
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.PokemonList.Any(pokemon => pokemon.Element == elementCommand))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.PokemonList)
                        {
                            pokemon.Health -= 10;
                        }
                    }

                    trainer.PokemonList.RemoveAll(x => x.Health <= 0);
                }

                elementCommand = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonList.Count}");
            }
        }
    }
}
