namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> chat = new List<string>();

            while (input != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Chat")
                {
                    chat.Add(command[1]);
                }
                else if (command[0] == "Delete")
                {
                    chat.Remove(command[1]);
                }
                else if (command[0] == "Edit")
                {
                    if (chat.Contains(command[1]))
                    {
                        int index = chat.IndexOf(command[1]);
                        chat.RemoveAt(index);
                        chat.Insert(index, command[2]);
                    }
                    
                }
                else if (command[0] == "Pin")
                {
                    if (chat.Contains(command[1]))
                    {
                        chat.Remove(command[1]);
                        chat.Add(command[1]);
                    }
                }
                else if (command[0] == "Spam")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        chat.Add(command[i]);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, chat));
        }
    }
}