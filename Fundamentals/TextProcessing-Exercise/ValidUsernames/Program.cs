namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var username in usernames)
            {
                if (IsUserNameValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsUserNameValid(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            foreach (var character in username)
            {
                if (character != '_' && character != '-' && (!char.IsLetter(character) && (!char.IsDigit(character))))
                {
                    return false;
                }
            }
            return true;
        }
    }
}