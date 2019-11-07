namespace P03_Articles2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var articles = new List<Article>();

            for (int i = 0; i < lines; i++)
            {
                var currentArticle = Console.ReadLine().Split(", ");
                string currentTitle = currentArticle[0];
                string currentContent = currentArticle[1];
                string currentAuthor = currentArticle[2];

                var article = new Article(currentTitle, currentContent, currentAuthor);
                articles.Add(article);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;

                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;

                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
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
