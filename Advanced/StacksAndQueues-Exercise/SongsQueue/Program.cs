using System.Text;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries));

            while (songs.Count != 0)
            {
                string command = Console.ReadLine();

                if (command[0] == 'A')
                {
                    string songName = command.Substring(4);
                    if (!songs.Contains(songName))
                    {
                        songs.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
                else if (command[0] == 'P')
                {
                    if (songs.Count != 0)
                    {
                        songs.Dequeue();
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
