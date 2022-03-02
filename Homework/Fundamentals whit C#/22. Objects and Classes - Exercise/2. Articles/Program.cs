using System;
using System.Linq;

namespace _2._Articles
{
    class Article
    {
        public Article(string rename, string edit, string changeAuthor)
        {
            this.Title = rename;
            this.Content = edit;
            this.Author = changeAuthor;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int numberOfCommands = int.Parse(Console.ReadLine());
            string rename = articleInput[0];
            string edit = articleInput[1];
            string changeAuthor = articleInput[2];
            Article article = new Article(rename, edit, changeAuthor);
            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "Edit":
                        article.Content = command[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = command[1];
                            break;
                    case "Rename":
                        article.Title = command[1];
                        break;      
                    default:
                        break;
                }              
            }
            Console.WriteLine(article.ToString());
        }
    }
}
