namespace P05_TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                var newTeam = Console.ReadLine().Split("-");
                string creator = newTeam[0];
                string teamName = newTeam[1];

                bool teamExists = teams.Any(x => x.TeamName == teamName);
                bool creatorExists = teams.Any(x => x.CreatorName == creator);

                if (teamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else if (creatorExists)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }

                else if (!teamExists && !creatorExists)
                {
                    var currentTeam = new Team(teamName, creator)
                    {
                        TeamName = teamName,
                        CreatorName = creator
                    };

                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split("->");

                if (command[0] == "end of assignment")
                {
                    break;
                }

                string user = command[0];
                string teamName = command[1];

                bool userExists = teams.Any(x => x.Members.Contains(user) || x.CreatorName == user);
                bool teamExists = teams.Any(x => x.TeamName == teamName);

                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                else if (teamExists && userExists)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }

                else if (teamExists && !userExists)
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(user);
                }
            }

            List<Team> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team> disbandTeams = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.CreatorName);

                team.Members = team.Members
                    .OrderBy(x => x).ToList();

                for (int i = 0; i < team.Members.Count; i++)
                {
                    Console.WriteLine("-- " + team.Members[i]);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    public class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }
    }
}
