using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                articles.Add(article);

                Console.WriteLine(article);
            }
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



        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}