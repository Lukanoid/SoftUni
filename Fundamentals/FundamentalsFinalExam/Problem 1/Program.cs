using System;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (data[0] == "Change")
                {
                    char sub = char.Parse(data[1]);
                    char replacement = char.Parse(data[2]);

                    input = input.Replace(sub, replacement);
                    Console.WriteLine(input);
                }
                else if (data[0] == "Includes")
                {
                    string sub = data[1];
                    if (input.Contains(sub))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (data[0] == "End")
                {
                    string sub = data[1];
                    int lenght = sub.Length;
                    string ending = input.Substring(input.Length - lenght);
                    if (ending == sub)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (data[0] == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (data[0] == "FindIndex")
                {
                    char character = char.Parse(data[1]);
                    Console.WriteLine(input.IndexOf(character));
                }
                else
                {
                    int startIndex = int.Parse(data[1]);
                    int count = int.Parse(data[2]);
                    Console.WriteLine(input.Substring(startIndex, count));
                    input = input.Remove(startIndex, count);
                }
            }

        }


    }
}