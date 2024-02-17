using System.Net.Http.Json;
using System.Runtime.InteropServices;

namespace TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers =
                new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                if (!input.Contains("followed"))
                {
                    string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string vloggerName = tokens[0];

                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        vloggers[vloggerName].Add("followers", new HashSet<string>());
                        vloggers[vloggerName].Add("following", new HashSet<string>());
                    }
                }
                else
                {
                    string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string follower = tokens[0];
                    string followed = tokens[2];

                    if (vloggers.ContainsKey(follower) && follower != followed && vloggers.ContainsKey(followed))
                    {
                        if (!vloggers[follower]["following"].Contains(followed))
                        {
                            vloggers[follower]["following"].Add(followed);
                            vloggers[followed]["followers"].Add(follower);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count} vloggers in its logs.");

            vloggers = vloggers.OrderByDescending(x=> x.Value["followers"].Count)
                .ThenBy(x=> x.Value["following"].Count)
                .ToDictionary(x => x.Key, x => x.Value);

            int count = 1;

            foreach (var vlogger in vloggers)
            {
                if (count == 1)
                {
                    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                    foreach (var follower in vlogger.Value["followers"].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                else
                {
                    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                }
                count++;
            }
        }
    }
}
