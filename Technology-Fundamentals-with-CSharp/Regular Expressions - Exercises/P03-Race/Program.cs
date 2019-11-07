namespace P03_Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var racers = Console.ReadLine().Split(", ");
            var contest = new Dictionary<string, int>();

            foreach (var racer in racers)
            {
                contest.Add(racer, 0);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    var finalThree = contest.OrderByDescending(x => x.Value).Take(3);
                    string[] places = new string[] { "1st", "2nd", "3rd" };
                    int i = 0;

                    foreach (var person in finalThree)
                    {
                        Console.WriteLine($"{places[i]} place: {person.Key}");
                        i++;
                    }

                    break;
                }

                char[] result = input.Where(x => char.IsLetter(x)).Select(x => x).ToArray();
                string racer = new string(result);

                if (!contest.ContainsKey(racer))
                {
                    continue;
                }

                var digits = input.Where(x => char.IsDigit(x)).ToList();

                foreach (var digit in digits)
                {
                    contest[racer] += (int)char.GetNumericValue(digit);
                }
            }
        }
    }
}
