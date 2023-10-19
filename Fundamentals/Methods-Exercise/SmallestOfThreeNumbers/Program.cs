namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            SmallestNum(firstNum, secondNum, thirdNum);
        }

        static void SmallestNum(int firstNum, int secondNum, int thirdNum)
        {

            if (firstNum < secondNum && firstNum < thirdNum)
            {
                Console.WriteLine(firstNum);
            }
            else if (secondNum < firstNum && secondNum < thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else
            {
                Console.WriteLine(thirdNum);
            }
        }
    }
}