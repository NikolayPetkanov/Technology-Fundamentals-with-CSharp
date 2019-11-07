namespace P02_Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var contests = new Dictionary<string, Dictionary<string, int>>();
            var participants = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var command = Console.ReadLine().Split(" -> ");

                if (command[0] == "no more time")
                {
                    break;
                }

                string participant = command[0];
                string contest = command[1];
                int points = int.Parse(command[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = new Dictionary<string, int>();
                    contests[contest].Add(participant, points);
                }

                else if (!contests[contest].ContainsKey(participant))
                {
                    contests[contest].Add(participant, points);
                }

                else if (contests[contest][participant] < points)
                {
                    contests[contest][participant] = points;
                }

                if (!participants.ContainsKey(participant))
                {
                    participants[participant] = new Dictionary<string, int>();
                    participants[participant].Add(contest, points);
                }

                else if (!participants[participant].ContainsKey(contest))
                {
                    participants[participant].Add(contest, points);
                }

                else if (participants[participant][contest] < points)
                {
                    participants[participant][contest] = points;
                }
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                var result = contest.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);

                int counter = 0;

                foreach (var participant in result)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {participant.Key} <::> {participant.Value}");
                }
            }

            Console.WriteLine("Individual standings:");
            int rank = 0;

            var finalStandings = participants
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key);

            foreach (var participant in finalStandings)
            {
                rank++;
                Console.WriteLine($"{rank}. {participant.Key} -> {participant.Value.Values.Sum()}");
            }
        }
    }
}
