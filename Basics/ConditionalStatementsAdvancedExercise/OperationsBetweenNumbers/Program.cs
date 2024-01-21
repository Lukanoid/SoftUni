using System;

namespace OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string symbol  = Console.ReadLine();

            double result = 0;

            switch (symbol)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "%":
                    result = n1 % n2;
                    break;
            }
            if ((symbol == "%" || symbol == "/") && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            if (symbol== "+" || symbol == "-" || symbol == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == "/" && n2 != 0)
            {
                Console.WriteLine($"{n1} {symbol} {n2} = {result:f2}");
            }
            else if (symbol == "%" && n2 != 0)
            {
                Console.WriteLine($"{n1} {symbol} {n2} = {result}");
            }           
        }
    }
}