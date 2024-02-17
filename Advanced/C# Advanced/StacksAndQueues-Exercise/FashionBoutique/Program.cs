namespace FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            int rackCounter = 0;
            int currentRack = 0;
            bool isFirst = false;

            Stack<int> clothingStack = new Stack<int>(clothes);

            while (clothingStack.Count != 0)
            {
                
                if (!isFirst)
                {
                    currentRack += clothingStack.Pop();
                    isFirst = true;
                    rackCounter++;
                }
                else
                {
                    if (currentRack + clothingStack.Peek() < capacity)
                    {
                        currentRack += clothingStack.Pop();
                    }
                    else if (currentRack + clothingStack.Peek() == capacity)
                    {
                        currentRack = 0;
                        clothingStack.Pop();
                        if (clothingStack.Any())
                        {
                            rackCounter++;
                        }
                    }
                    else
                    {
                        currentRack = clothingStack.Pop();
                        rackCounter++;
                    }
                }
            }

            Console.WriteLine(rackCounter);
        }
    }
}
