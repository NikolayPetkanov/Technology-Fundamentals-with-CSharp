namespace P06_Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var contests = new List<Contest>();
            var individualStats = new Dictionary<string, int>();
            int counter = 0;

            while (true)
            {
                var input = Console.ReadLine().Split(" -> ");

                if (input[0] == "no more time")
                {
                    PrintSortedRanks(counter, contests, individualStats);

                    PrintSortedStats(counter, individualStats);

                    break;
                }

                string contestName = input[1];
                string participantName = input[0];
                int participantPoints = int.Parse(input[2]);

                var currentContest = new Contest(contestName, participantName, participantPoints);

                int index = contests.FindIndex(c => c.ContestName == currentContest.ContestName);

                if (index == -1)
                {
                    contests.Add(currentContest);
                }

                else
                {
                    if (!contests[index].ParticipantNameAndPoints.ContainsKey(participantName))
                    {
                        contests[index].ParticipantNameAndPoints.Add(participantName, participantPoints);
                    }

                    else if (contests[index].ParticipantNameAndPoints[participantName] < participantPoints)
                    {
                        contests[index].ParticipantNameAndPoints[participantName] = participantPoints;
                    }
                }

                
            }
        }
        

        public static void PrintSortedRanks(int counter, List<Contest> contests,
            Dictionary<string, int> individualStats)
        {
            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.ContestName}: " +
                    $"{contest.ParticipantNameAndPoints.Count} participants");

                var sortedRanks = contest.ParticipantNameAndPoints
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key);

                counter = 0;

                foreach (var participant in sortedRanks)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {participant.Key} <::> {participant.Value}");

                    if (!individualStats.ContainsKey(participant.Key))
                    {
                        individualStats.Add(participant.Key, participant.Value);
                    }

                    else
                    {
                        individualStats[participant.Key] += participant.Value;
                    }
                }
            }
        }

        public static void PrintSortedStats(int counter, Dictionary<string, int> individualStats)
        {
            counter = 0;

            var sortedStats = individualStats
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key);

            Console.WriteLine($"Individual standings:");

            foreach (var participant in sortedStats)
            {
                counter++;
                Console.WriteLine($"{counter}. {participant.Key} -> {participant.Value}");
            }
        }
    }

    public class Contest
    {
        public string ContestName { get; set; }

        public Dictionary<string, int> ParticipantNameAndPoints { get; set; }

        public Contest(string contestName, string participantName, int participantPoints)
        {
            ContestName = contestName;
            ParticipantNameAndPoints = new Dictionary<string, int>();
            ParticipantNameAndPoints.Add(participantName, participantPoints);
        }
    }
}
