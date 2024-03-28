using System;
using System.Collections.Generic;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            Music music = new Music("Ed sheeran", "divide", 2, 100);
            File file = new File("Dota", 12, 45);
            TwitchStream twitchStream = new TwitchStream("Aethelthryth",12, 21);

            StreamProgressInfo stream = new StreamProgressInfo(music);

            StreamProgressInfo stream2 = new StreamProgressInfo(file);
            StreamProgressInfo stream3 = new StreamProgressInfo(twitchStream);

            List<StreamProgressInfo> streams = new List<StreamProgressInfo>();

            streams.Add(stream);
            streams.Add(stream2);
            streams.Add(stream3);

            foreach (var streamProgressInfo in streams)
            {
                Console.WriteLine($"Current stream byte percent sent is: {streamProgressInfo.CalculateCurrentPercent()}");
            }
        }
    }
}
