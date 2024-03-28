using P01.Stream_Progress.Interfaces;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStream stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStream file)
        {
            stream = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.stream.BytesSent * 100) / this.stream.Length;
        }
    }
}
