namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (var item in array)
            {
                queue.Enqueue(item);
            }

            bool firstEvenNumber = true;

            while (queue.Count != 0)
            {
                int currentNum = queue.Dequeue();

                if (currentNum % 2 == 0)
                {

                    if (!firstEvenNumber)
                    {
                        Console.Write(", ");
                    }

                    firstEvenNumber = false;
                    Console.Write($"{currentNum}");
                }
            }
        }
    }
}
