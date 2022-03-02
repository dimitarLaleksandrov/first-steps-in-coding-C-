using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
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
            int numOfStrings = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 1; i <= numOfStrings; i++)
            {
                string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string title = command[0];
                string content = command[1];
                string author = command[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            string orderBy = Console.ReadLine();
            switch (orderBy)
            {
                case "title":
                    articles = articles.OrderBy(a => a.Title).ToList();
                break;
                    case "content":
                    articles = articles.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(a => a.Author).ToList();
                    break;
                default:
                    break;
            }
            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
