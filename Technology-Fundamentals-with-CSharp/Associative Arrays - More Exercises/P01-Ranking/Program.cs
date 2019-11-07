namespace P01_Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var contestsAndPasswords = new Dictionary<string, string>();

            var newContest = Console.ReadLine().Split(":");

            while (newContest[0] != "end of contests")
            {
                string contest = newContest[0];
                string password = newContest[1];
                contestsAndPasswords[contest] = password;
                newContest = Console.ReadLine().Split(":");
            }

            var students = new Dictionary<string, Dictionary<string, int>>();

            var submission = Console.ReadLine().Split("=>");

            while (submission[0] != "end of submissions")
            {
                string contest = submission[0];
                string password = submission[1];
                string candidate = submission[2];
                int points = int.Parse(submission[3]);

                if (contestsAndPasswords.ContainsKey(contest) &&
                    contestsAndPasswords[contest] == password)
                {
                    if (!students.ContainsKey(candidate))
                    {
                        students[candidate] = new Dictionary<string, int>();
                        students[candidate].Add(contest, points);
                    }

                    else
                    {
                        if (!students[candidate].ContainsKey(contest))
                        {
                            students[candidate].Add(contest, points);
                        }

                        else if (students[candidate][contest] < points)
                        {
                            students[candidate][contest] = points;
                        }
                    }
                }

                submission = Console.ReadLine().Split("=>");
            }

            var bestCandidate = students.OrderByDescending(x => x.Value.Values.Sum()).First();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total" +
                $" {bestCandidate.Value.Values.Sum()} points.");

            Console.WriteLine("Ranking:");

            var result = students.OrderBy(x => x.Key);

            foreach (var student in result)
            {
                Console.WriteLine(student.Key);

                var pairs = student.Value.OrderByDescending(x => x.Value);

                foreach (var currentContest in pairs)
                {
                    Console.WriteLine($"#  {currentContest.Key} -> {currentContest.Value}");
                }
            }
        }
    }
}
