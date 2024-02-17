namespace SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> normalInvites = new HashSet<string>();
            HashSet<string> vipInvites = new HashSet<string>();

            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipInvites.Add(input);
                }
                else
                {
                    normalInvites.Add(input);
                }
                input = Console.ReadLine();
            }

            string peopleInvites = Console.ReadLine();

            while (peopleInvites != "END")
            {
                if (normalInvites.Contains(peopleInvites))
                {
                    normalInvites.Remove(peopleInvites);
                }
                else if (vipInvites.Contains(peopleInvites))
                {
                    vipInvites.Remove(peopleInvites);
                }
                peopleInvites = Console.ReadLine();
            }

            Console.WriteLine($"{vipInvites.Count + normalInvites.Count}");
            foreach (var invite in vipInvites)
            {
                Console.WriteLine(invite);
            }

            foreach (var invite in normalInvites)
            {
                Console.WriteLine(invite);
            }
        }
    }
}
