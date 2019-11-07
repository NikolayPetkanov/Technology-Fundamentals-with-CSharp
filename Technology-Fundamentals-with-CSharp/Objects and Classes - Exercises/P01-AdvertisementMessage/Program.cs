namespace P01_AdvertisementMessage
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            var phrases = new List<string>
            {
                    "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
            };

            var events = new List<string>
            {
                    "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new List<string>
            {
                 "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            var cities = new List<string>
            {
                 "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"

            };

            for (int i = 0; i < lines; i++)
            {
                Random random = new Random();
                var message = new List<string>();

                int phraseIndex = random.Next(0, phrases.Count);
                message.Add(phrases[phraseIndex]);

                int eventIndex = random.Next(0, events.Count);
                message.Add(events[eventIndex]);

                int authorIndex = random.Next(0, authors.Count);
                message.Add(authors[authorIndex]);

                int cityIndex = random.Next(0, cities.Count);
                message.Add(cities[cityIndex]);

                Console.WriteLine($"{message[0]} {message[1]} {message[2]} - {message[3]}");
            }
        }
    }
}
