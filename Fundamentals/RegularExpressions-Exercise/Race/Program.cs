using System.Text;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> participants = new Dictionary<string, int>();

            while (true)
            {
                string data = Console.ReadLine();

                if (data == "end of race")
                {
                    break;
                }

                StringBuilder currentName = new StringBuilder();
                int kilometersRan = 0;

                for (int i = 0; i < data.Length; i++)
                {
                    if (char.IsLetter(data[i]))
                    {
                        currentName.Append(data[i]);
                    }
                    else if (char.IsDigit(data[i]))
                    {
                        kilometersRan += data[i] - '0';
                    }
                }

                if (input.Contains(currentName.ToString()))
                {
                    if (participants.ContainsKey(currentName.ToString()))
                    {
                        participants[currentName.ToString()] += kilometersRan;
                    }
                    else
                    {
                        participants.Add(currentName.ToString(), kilometersRan);
                    }
                }
            }

            int place = 1;
            foreach (var participant in participants.OrderByDescending(x => x.Value).Take(3))
            {
                if (place == 1)
                {
                    Console.WriteLine($"1st place: {participant.Key}");
                }
                else if (place == 2)
                {
                    Console.WriteLine($"2nd place: {participant.Key}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {participant.Key}");
                }
                place++;
            }

        }
    }
}