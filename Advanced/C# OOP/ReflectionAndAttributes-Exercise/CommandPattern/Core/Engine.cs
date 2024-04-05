using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;


        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string result = null;

                try
                {
                    result = commandInterpreter.Read(input);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                if (result == null)
                {
                    break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
