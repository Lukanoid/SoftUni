using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {

        public IAnimal CreateAnimal(string[] animalArgs)
        {
            switch (animalArgs[0])
            {
                case "Cat":
                    return new Cat(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);
                case "Tiger":
                    return new Tiger(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);
                case "Owl":
                    return new Owl(animalArgs[1], double.Parse(animalArgs[2]), double.Parse(animalArgs[3]));
                case "Hen":
                    return new Hen(animalArgs[1], double.Parse(animalArgs[2]), double.Parse(animalArgs[3]));
                case "Mouse":
                    return new Mouse(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);
                case "Dog":
                    return new Dog(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);
                default:
                    throw new ArgumentException("Invlid type of animal");
            }
        }
    }
}
