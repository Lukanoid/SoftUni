/*
51 47 32 61 21
2

 
*/


namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            
            for (int j = 0; j < rotations; j++)
            {
                int firstElement = arr[0];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[arr.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}