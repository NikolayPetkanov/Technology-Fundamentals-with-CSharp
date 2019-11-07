namespace P05_Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var contestsAndPasswords = new Dictionary<string, string>();
            var candidates = new List<Submission>();

            while (true)
            {
                var pair = Console.ReadLine().Split(":");

                if (pair[0] == "end of contests")
                {
                    break;
                }

                contestsAndPasswords.Add(pair[0], pair[1]);
            }

            while (true)
            {
                var submission = Console.ReadLine().Split("=>");

                if (submission[0] == "end of submissions")
                {
                    var bestCandidate = candidates
                        .OrderByDescending(x => x.ContestsAndPoints.Values.Sum())
                        .First();

                    Console.WriteLine($"Best candidate is {bestCandidate.Candidate} " +
                        $"with total {bestCandidate.ContestsAndPoints.Values.Sum()} points.");

                    Console.WriteLine("Ranking:");

                    var result = candidates.OrderBy(x => x.Candidate);

                    foreach (var person in result)
                    {
                        Console.WriteLine($"{person.Candidate}");

                        var sortedResults = person.ContestsAndPoints
                            .OrderByDescending(x => x.Value);

                        foreach (var pair in sortedResults)
                        {
                            Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                        }
                    }

                    break;
                }

                string contest = submission[0];
                string password = submission[1];
                string candidate = submission[2];
                int points = int.Parse(submission[3]);

                if (contestsAndPasswords.ContainsKey(contest) &&
                    contestsAndPasswords[contest] == password)
                {
                    var currentCandidate = new Submission(candidate, contest, points);
                    currentCandidate.ContestsAndPoints.Add(contest, points);

                    int index = candidates.FindIndex(x => x.Candidate == candidate);

                    if (index == -1)
                    {
                        candidates.Add(currentCandidate);
                    }

                    else
                    {
                        if (!candidates[index].ContestsAndPoints.ContainsKey(contest))
                        {
                            candidates[index].ContestsAndPoints.Add(contest, points);
                        }

                        else if (candidates[index].ContestsAndPoints[contest] < points)
                        {
                            candidates[index].ContestsAndPoints[contest] = points;
                        }
                    }
                }
            }
        }

        public class Submission
        {
            public string Candidate { get; set; }

            public Dictionary<string, int> ContestsAndPoints { get; set; }

            public string Contest { get; set; }

            public int Points { get; set; }

            public Submission(string candidate, string contest, int points)
            {
                Candidate = candidate;
                ContestsAndPoints = new Dictionary<string, int>();
            }
        }
    }
}
