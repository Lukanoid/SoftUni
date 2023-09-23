using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string reversedUsername = new string (stringArray);
            string newAttempt = "";
            int attemptCounter = 1;

            while (true)
            {
                newAttempt = Console.ReadLine();
                attemptCounter++;
                if(newAttempt == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (attemptCounter > 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }
            
        }
    }
}