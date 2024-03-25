using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseHero.IO.Interfaces;

namespace BaseHero.IO
{
    public class FileWriter : IWriter
    {
        public void WriteLine(string str)
        {
            using StreamWriter writer = new StreamWriter("../../../output.txt", true);

            writer.WriteLine(str);
        }
    }
}
