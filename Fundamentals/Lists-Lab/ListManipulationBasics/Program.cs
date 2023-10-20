namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);
                }
                else if (command[0] == "Remove")
                {
                    int number = int.Parse(command[1]);
                    numbers.Remove(number);
                }
                else if (command[0] == "RemoveAt")
                {
                    int number = int.Parse(command[1]);
                    numbers.RemoveAt(number);
                }
                else
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                }

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}