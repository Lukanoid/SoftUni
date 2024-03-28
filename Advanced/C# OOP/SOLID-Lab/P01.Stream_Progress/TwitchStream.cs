using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P01.Stream_Progress.Interfaces;

namespace P01.Stream_Progress
{
    public class TwitchStream : IStream
    {
        public TwitchStream(string streamerName, int length, int bytesSent)
        {
            StreamerName = streamerName;
            Length = length;
            BytesSent = bytesSent;
        }
        public int Length { get; set; }
        public int BytesSent { get; set; }
        public string StreamerName { get; set; }
    }
}
