using System;
using System.Linq;
using System.Collections.Generic;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string creator = command[0];
                string teamName = command[1];
                Team currTeam = new Team(creator, teamName);

                if (teams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.User == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team(creator, teamName);
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string cmd = Console.ReadLine();
            while (cmd != "end of assignment")
            {
                string[] splitCmd = cmd.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = splitCmd[0];
                string teamToJoin = splitCmd[1];

                if (teams.All(team => team.TeamName != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(team => team.Members.Contains(user)) || teams.Any(creator => creator.User == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }

                else
                {
                    Team currentTeam = teams.Find(team => team.TeamName == teamToJoin);
                    currentTeam.Members.Add(user);
                }
                cmd = Console.ReadLine();
            }

            List<Team> completedTeams = teams.Where(team => team.Members.Count > 0).ToList();
            List<Team> uncompletedTeams = teams.Where(team => team.Members.Count == 0).ToList();

            foreach (var item in completedTeams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.TeamName))
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.User}");
                item.Members.Sort();
                foreach (var member in item.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");

            if (uncompletedTeams.Count > 0)
            {
                foreach (var item in uncompletedTeams.OrderBy(x => x.TeamName))
                {
                    Console.WriteLine(item.TeamName);
                }
            }

        }

    }
}

public class Team
{
    public string User { get; set; }
    public string TeamName { get; set; }

    public List<string> Members { get; set; }

    public Team(string user, string teamName)
    {
        this.TeamName = teamName;
        this.User = user;
    }

}