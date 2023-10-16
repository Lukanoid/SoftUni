namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = Caclculate(firstNum, type, secondNum);

            Console.WriteLine(result);
        }

        static double Caclculate(int firstNum, string type, int secondNum)
        {
            double result = 0;

            switch (type)
            {
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
            }
            return result;
        }
    }
}