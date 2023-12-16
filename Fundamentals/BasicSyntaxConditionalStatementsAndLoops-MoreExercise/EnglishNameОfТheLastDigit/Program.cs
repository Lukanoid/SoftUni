using System.Threading.Channels;

namespace EnglishNameОfТheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine(); 
            var lastNumber = number.TakeLast(1).ToArray();
            char num = lastNumber[0];

            Console.WriteLine(LastNumAsWord(num));
        }

        public static string LastNumAsWord(int num)
        {
            switch ((int)num)
            {
                case 48:
                    return "zero";
                    break;
                case 49:
                    return "one";
                    break;
                case 50:
                    return "two";
                    break;
                case 51:
                    return "three";
                    break;
                case 52:
                    return "four";
                    break;
                case 53:
                    return "five";
                    break;
                case 54:
                    return "six";
                    break;
                case 55:
                    return "seven";
                    break;
                case 56:
                    return "eight";
                    break;
                default:
                    return "nine";
                    break;

            }
        }
    }
}
