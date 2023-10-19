namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (!PasswordLenghtValidation(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!PasswordLettersAndDigitsValidation(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!PassowordTwoDigitsValidation(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (PasswordLettersAndDigitsValidation(password) && PassowordTwoDigitsValidation(password) && PasswordLenghtValidation(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PasswordLenghtValidation(string password)
        {
            bool isLenghtEnough = true;
            if (password.Length < 6 || password.Length > 10)
            {
                isLenghtEnough = false;
            }
            return isLenghtEnough;
        }

        static bool PasswordLettersAndDigitsValidation(string password)
        {
            bool isDigitOrLetter = true;
            foreach (var character in password)
            {
                if ((character > 47 && character < 58) || (character > 64 && character < 91) || (character > 96 && character < 123))
                {
                    isDigitOrLetter = true;
                }
                else
                {
                    isDigitOrLetter = false;
                    break;
                }
            }
            return isDigitOrLetter;
        }

        static bool PassowordTwoDigitsValidation(string password)
        {
            int digitsCount = 0;
            bool areDigitsMoreThanTwo = false;
            foreach (var character in password)
            {
                if (character > 47 && character < 58)
                {
                    digitsCount++;
                    if (digitsCount > 1)
                    {
                        areDigitsMoreThanTwo = true;
                        break;
                    }
                }
            }
            return areDigitsMoreThanTwo;
        }
    }
}