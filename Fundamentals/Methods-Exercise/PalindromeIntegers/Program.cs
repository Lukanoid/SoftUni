namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else if (IsNumberPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool IsNumberPalindrome(string input)
        {
            
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string reversedInput = new string(arr);
            if (reversedInput == input)
            {
                return true;
            }
            else
            {
                return false;
            }
            //string cleanInput = new string(input.Where(char.IsDigit).ToArray());
            //
            //char[] arr = cleanInput.ToCharArray();
            //Array.Reverse(arr);
            //string reversedInput = new string(arr);
            //
            //return cleanInput.Equals(reversedInput);
        }
    }
}