using System.Data;

namespace ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] createCommand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

            CustomListyIterator<string> listyIterator = new CustomListyIterator<string>(createCommand.ToList());

            string command = Console.ReadLine();

            while (command != "END")
            {

                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch(InvalidOperationException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }

                        break;
                    case "PrintAll":
                        foreach (var item in listyIterator)
                        {
                            Console.Write($"{item} ");
                        }

                        Console.WriteLine();
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
