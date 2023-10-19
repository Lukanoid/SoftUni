namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Matrix(number);
        }

        static void Matrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                int[] arr = new int[number];

                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = number;
                }

                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}