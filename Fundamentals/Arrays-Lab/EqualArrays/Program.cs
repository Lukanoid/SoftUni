namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool isValid = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    sum += arr1[i];
                }
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isValid = false;
                    break;
                }
            }
            if(isValid)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}