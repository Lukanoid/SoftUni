namespace CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> kvp = new Dictionary<double, int>();

            foreach (double value in input)
            {
                if (!kvp.ContainsKey(value))
                {
                    kvp.Add(value, 1);
                }
                else
                {
                    kvp[value] ++;
                }
            }

            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
