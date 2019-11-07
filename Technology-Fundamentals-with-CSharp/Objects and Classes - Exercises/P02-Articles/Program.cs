namespace P02_Articles
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var currentArticle = Console.ReadLine().Split(", ");
            string currentTitle = currentArticle[0];
            string currentContent = currentArticle[1];
            string currentAuthor = currentArticle[2];

            var article = new Article(currentTitle, currentContent, currentAuthor);

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(": ");

                switch (input[0])
                {
                    case "Edit":
                        string newContent = input[1];
                        article.Edit(newContent);
                        break;

                    case "ChangeAuthor":
                        string newAuthor = input[1];
                        article.ChangeAuthor(newAuthor);
                        break;

                    case "Rename":
                        string newTitle = input[1];
                        article.Rename(newTitle);
                        break;
                }
            }

            Console.WriteLine(article);
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
