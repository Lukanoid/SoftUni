namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            while (true)
            {
                int startIndex = secondInput.IndexOf(firstInput);

                if (startIndex == -1)
                {
                    break;
                }

                secondInput = secondInput.Remove(startIndex, firstInput.Length);
            }

            Console.WriteLine(secondInput);
            
        }
    }
}