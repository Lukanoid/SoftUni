namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            if (queue.Any())
            {
                Console.WriteLine(queue.Max());
            }

            while (queue.Count != 0)
            {
                int currentOrder = queue.Peek();
                if (totalFood - currentOrder >= 0)
                {
                    totalFood-=currentOrder;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
                
            }

            if (queue.Count != 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine($"Orders complete");
            }
        }
    }
}
