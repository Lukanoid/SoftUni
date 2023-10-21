namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[2] == "going!")
                {
                    bool isGuestOnTheList = false;
                    for (int j = 0; j < guests.Count; j++)
                    {
                        if (guests[j] == command[0])
                        {
                            Console.WriteLine(command[0] + " is already in the list!");
                            isGuestOnTheList = true;
                        }
                    }

                    if (!isGuestOnTheList)
                    {
                        guests.Add(command[0]);
                    }
                }
                else
                {
                    bool isGuestOnTheList = false;
                    for (int j = 0; j < guests.Count; j++)
                    {
                        if (guests[j] == command[0])
                        {
                            guests.Remove(command[0]);
                            isGuestOnTheList = true;

                        }
                    }

                    if (!isGuestOnTheList)
                    {
                        Console.WriteLine(command[0] + " is not in the list!");
                    }
                }


            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}