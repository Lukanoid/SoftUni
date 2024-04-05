using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core;

public class CommandInterpreter : ICommandInterpreter
{
    public string Read(string args)
    {
        string[] arguments = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string commandName = arguments[0];

        Type[] commandType = Assembly.GetEntryAssembly().GetTypes();

        commandType = commandType.Where(x => x.Name.EndsWith("Command") && x.Name.StartsWith(commandName)).ToArray();

        if (commandType.Length == 0)
        {
            throw new IndexOutOfRangeException("Invalid input");
        }

        ICommand instance = Activator.CreateInstance(commandType[0]) as ICommand;

        return instance.Execute(arguments.Skip(1).ToArray()); ;
    }
}