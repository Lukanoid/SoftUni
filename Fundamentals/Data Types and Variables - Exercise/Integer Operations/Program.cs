namespace Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int output = firstNum + secondNum;
            output /= thirdNum;
            output *= fourthNum;

            Console.WriteLine(output);
        }
    }
}