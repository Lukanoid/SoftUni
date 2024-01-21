using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string[]> undoStack = new Stack<string[]>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] data = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (data[0] == "1")
                {
                    sb.Append(data[1]);
                    undoStack.Push(data);
                }
                else if (data[0] == "2")
                {
                    int count = int.Parse(data[1]);
                    string sub = sb.ToString().Substring(sb.Length- count);
                    sb.Remove(sb.Length - count, count);
                    string[] undoArray = new string[2];
                    undoArray[0] = data[0];
                    undoArray[1] = sub;
                    undoStack.Push(undoArray);
                }
                else if (data[0] == "3")
                {
                    string text = sb.ToString();
                    Console.WriteLine(text.ElementAt(int.Parse(data[1]) - 1));
                }
                else if (data[0] == "4")
                {
                    string[] undo = undoStack.Pop();
                    if (undo[0] == "1")
                    {
                        int lenght = undo[1].Length;
                        sb.Remove(sb.Length - lenght, lenght);
                    }
                    else if (undo[0] == "2")
                    {
                        sb.Append(undo[1]);
                    }
                }
            }
        }
    }
}
