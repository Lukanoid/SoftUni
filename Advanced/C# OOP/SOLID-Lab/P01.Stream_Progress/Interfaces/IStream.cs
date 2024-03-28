using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace P01.Stream_Progress.Interfaces
{
    public interface IStream
    {
        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}
