using System;
using System.Collections.Generic;
using WildFarm.Core.Interfaces;
using WildFarm.Factories.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core;

public class Engine : IEngine
{

    private readonly IAnimalFactory animalFactory;
    private readonly IFoodFactory foodFactory;

    private readonly ICollection<IAnimal> animals;

    public Engine(
        IAnimalFactory animalFactory,
        IFoodFactory foodFactory)
    {

        this.animalFactory = animalFactory;
        this.foodFactory = foodFactory;

        animals = new List<IAnimal>();
    }

    public void Run()
    {
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            IAnimal animal = null;

            try
            {
                animal = CreateAnimal(command);

                IFood food = CreateFood();

                Console.WriteLine(animal.ProduceSound());

                animal.Eat(food);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }

            animals.Add(animal);
        }

        foreach (IAnimal animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private IAnimal CreateAnimal(string command)
    {
        string[] animalArgs = command
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        IAnimal animal = animalFactory.CreateAnimal(animalArgs);

        return animal;
    }

    private IFood CreateFood()
    {
        string[] foodTokens = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string foodType = foodTokens[0];
        int foodQuantity = int.Parse(foodTokens[1]);

        IFood food = foodFactory.CreateFood(foodType, foodQuantity);

        return food;
    }
}