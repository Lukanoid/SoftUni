using System.Threading.Channels;

namespace AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();


            Func<List<int>, List<int>> function = null;
            Action<List<int>> printAction = numbers => Console.WriteLine(string.Join(" ", numbers));


            while (command != "end")
            {
                if (command == "add")
                {
                    function = ApplyArithmeticsFunc(command);
                    numbers = function(numbers);
                }
                else if (command == "multiply")
                {
                    function = ApplyArithmeticsFunc(command);
                    numbers = function(numbers);
                }
                else if (command == "subtract")
                {
                    function = ApplyArithmeticsFunc(command);
                    numbers = function(numbers);
                }
                else if (command == "print")
                {
                    printAction(numbers);
                }

                command = Console.ReadLine();
            }
        }

        static Func<List<int>, List<int>> ApplyArithmeticsFunc(string command)
        {
            Func<List<int>, List<int>> function = null;
            List<int> result = new List<int>();
            if (command == "add")
            {
                function = numbers =>
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        result.Add(numbers[i] + 1);
                    }

                    return result;
                };
            }
            else if (command == "multiply")
            {
                function = numbers =>
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        result.Add(numbers[i] * 2);
                    }
                    return result;
                };
            }
            else if (command == "subtract")
            {
                function = numbers =>
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        result.Add(numbers[i] - 1);
                    }
                    return result;
                };
            }

            return function;
        }
    }
}
