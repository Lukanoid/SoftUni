namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);

                string TypeList = input[0];
                string Name = input[1];
                string Duration = input[2];

                Song song = new Song();

                song.TypeList = TypeList;
                song.Name = Name;
                song.Duration = Duration;

                songs.Add(song);
            }

            string searchedTypeList = Console.ReadLine();

            if (searchedTypeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == searchedTypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

        class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Duration { get; set; }
        }
    }
}