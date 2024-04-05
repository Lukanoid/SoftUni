using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
            => null;
    }
}
