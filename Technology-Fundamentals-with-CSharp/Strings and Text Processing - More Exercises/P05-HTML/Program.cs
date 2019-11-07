namespace P05_HTML
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();
            var comments = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of comments")
                {
                    break;
                }

                comments.Add(input);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");

            Console.WriteLine("<article>");
            Console.WriteLine($"    {article}");
            Console.WriteLine("</article>");

            foreach (var comment in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment}");
                Console.WriteLine("</div>");
            }
        }
    }
}
