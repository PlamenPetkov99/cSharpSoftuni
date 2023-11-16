using System.Reflection.Metadata;

namespace teamworkProject
{
    internal class Program
    {

        /*
         3
         Tanya-CloneClub
         Helena-CloneClub
         Tanya-CloneClub
        ???????????????????????????????? dali trqbva da ima i dvete greshki ili samo 1
         */
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < count; i++)
            {
                string[] inputTokens = Console.ReadLine().Split("-").ToArray();//John-PowerPuffsCoders
                Team team = new Team();
                team.Members = new List<string>();
                bool isNotCreated = true;
                bool isNotCreate = true;
                team.Creator = inputTokens[0];
                team.Members.Add(team.Creator);
                team.TeamName = inputTokens[1];

                foreach (Team currentTeam in teams) //•	If а user tries to create a team more than once
                {
                    if(currentTeam.TeamName == team.TeamName)
                    {
                        Console.WriteLine($"Team {currentTeam.TeamName} was already created!");
                        isNotCreated = false;
                        break;
                    }
                }

                foreach (Team currentTeam in teams)//•	A creator of a team cannot create another team
                {
                    if(currentTeam.Creator == team.Creator)
                    {
                        Console.WriteLine($"{currentTeam.Creator} cannot create another team!");
                        isNotCreate = false;
                        break;
                    }
                }
                if (isNotCreated == true && isNotCreate == true)
                {
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
                    teams.Add(team);
                }

            }

            string input = default;
            while ((input = Console.ReadLine()) != "end of assignment") //Peter->PowerPuffsCoders
            {
                string[] inputTokens = input.Split("->").ToArray();
                string userToJoin = inputTokens[0];
                string teamNameJoin = inputTokens[1];
                bool flagCreated = false;
                bool flagJoined = false;




                foreach (Team item in teams)//•	If а user tries to join a non-existent team, a message should be displayed
                {
                    if(item.TeamName == teamNameJoin)
                    {
                        flagCreated = true;
                        break;
                    }
                }
                if (flagCreated == false)
                {
                    Console.WriteLine($"Team {teamNameJoin} does not exist!");
                }

                foreach (Team item in teams)//•	A member of a team cannot join another team
                {
                    if (item.Members.Contains(userToJoin))
                    {
                        flagJoined = true;
                        break;
                    }
                }
                if (flagJoined)
                {
                    Console.WriteLine($"Member {userToJoin} cannot join team {teamNameJoin}!");
                }

                if(flagCreated == true && flagJoined == false)
                {
                    foreach (Team item in teams)
                    {
                        if(item.TeamName == teamNameJoin)
                        {
                            item.Members.Add(userToJoin);
                            break;
                        }
                    }
                }


            }

            List<Team> validTeams = teams.Where(x => x.Members.Count > 1).ToList();
            List<Team> invalidTeams = teams.Where(x => x.Members.Count <= 1).ToList();

            //print valid
            List<Team> orderedValid = validTeams.OrderBy(x => x.TeamName).ToList();

            foreach (Team item in validTeams)
            {
                Console.WriteLine($"{item.TeamName}");//SoftUni
                Console.WriteLine($"- {item.Creator}");//-Tedy
                
                for (int i = 1; i < item.Members.Count; i++)
                {

                    Console.WriteLine($"-- {item.Members[i]}");
                }
                //-- George
                //-- John

            }


            //print invalid
            Console.WriteLine($"Teams to disband:");
            List<Team> orderedInvalid = invalidTeams.OrderBy(x => x.TeamName).ToList();
            foreach (Team item in orderedInvalid)
            {
                Console.WriteLine($"{item.TeamName}");
            }


        }
    }

    public class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; } 

        
        public List<string> Members { get; set; }
    }
}