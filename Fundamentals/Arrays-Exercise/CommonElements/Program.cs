namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split();
            string[] arr2 = Console.ReadLine()
            .Split();

            var commonElements = arr2.Intersect(arr1);

            foreach (var element in commonElements)
            {
                Console.Write(element + " ");
            }
        }
    }
}