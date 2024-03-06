namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] animalData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                    switch (command)
                    {
                        case "Cat":
                            Cat cat = new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine(command);
                            Console.WriteLine(cat);
                            cat.ProduceSound();
                            break;
                        case "Dog":
                            Dog dog = new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine(command);
                            Console.WriteLine(dog);
                            dog.ProduceSound();
                            break;
                        case "Frog":
                            Frog frog = new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine(command);
                            Console.WriteLine(frog);
                            frog.ProduceSound();
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(animalData[0], int.Parse(animalData[1]));
                            Console.WriteLine(command);
                            Console.WriteLine(kitten);
                            kitten.ProduceSound();
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(animalData[0], int.Parse(animalData[1]));
                            Console.WriteLine(command);
                            Console.WriteLine(tomcat);
                            tomcat.ProduceSound();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
