namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (var item in sequence)
            {
                try
                {
                    sum += (int)ProccedCommand(item);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");

        }
        static long ProccedCommand(string item)
        {
            long number;
            if (long.TryParse(item, out number))
            {
                if (number is <= int.MaxValue and >= int.MinValue)
                {
                    return number;
                }

                throw new OverflowException($"The element '{item}' is out of range!");
            }

            throw new FormatException($"The element '{item}' is in wrong format!");

        }
    }
}
