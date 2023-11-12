using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    string newContent = command[1];
                    article.Edit(newContent);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    article.ChangeAuthor(newAuthor);
                }
                else
                {
                    string newTitle = command[1];
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article.ToString());

        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}