namespace P02_SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var participants = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split("-");

                if (input[0] == "exam finished")
                {
                    var sortedParticipants = participants
                        .OrderByDescending(p => p.Value)
                        .ThenBy(p => p.Key);

                    Console.WriteLine("Results:");

                    foreach (var participant in sortedParticipants)
                    {
                        Console.WriteLine($"{participant.Key} | {participant.Value}");
                    }

                    var sortedSubmissions = submissions
                        .OrderByDescending(s => s.Value)
                        .ThenBy(s => s.Key);

                    Console.WriteLine("Submissions:");

                    foreach (var submission in sortedSubmissions)
                    {
                        Console.WriteLine($"{submission.Key} - {submission.Value}");
                    }

                    break;
                }

                string name = input[0];

                if (input[1] == "banned")
                {
                    if (participants.ContainsKey(name))
                    {
                        participants.Remove(name);
                    }

                    continue;
                }

                string language = input[1];
                int points = int.Parse(input[2]);

                if (!participants.ContainsKey(name))
                {
                    participants.Add(name, points);
                }

                else if (participants[name] < points)
                {
                    participants[name] = points;
                }

                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 0);
                }

                submissions[language]++;
            }
        }
    }
}
