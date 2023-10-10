namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] forPrinting = new string[input];
            string[] forPrinting2 = new string[input];

            for (int i = 0; i < input; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(" ");
                if (i % 2 == 0)
                {
                   forPrinting[i] = arr[0];
                   forPrinting2[i] = arr[1];
                    
                }
                else
                {
                    forPrinting[i] = arr[1];
                    forPrinting2[i] = arr[0];
                }


            }

            Console.WriteLine(string.Join(" ", forPrinting));
            Console.WriteLine(string.Join(" ", forPrinting2));

        }
    }
}