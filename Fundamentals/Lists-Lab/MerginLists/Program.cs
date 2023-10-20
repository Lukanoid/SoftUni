namespace MerginLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            if (first.Count > second.Count)
            {
                for (int i = 0; i < second.Count; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                }

                for (int i = second.Count; i < first.Count; i++)
                {
                    result.Add(first[i]);
                }
            }
            else if (second.Count > first.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                }

                for (int i = first.Count; i < second.Count; i++)
                {
                    result.Add(second[i]);
                }
            }
            else
            {
                for (int i = 0; i < first.Count; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}