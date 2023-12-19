using System.Numerics;

namespace mobaChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            Dictionary<string, Dictionary<string, int>> playerNamePositionSkill = new Dictionary<string, Dictionary<string, int>>();
            while((line = Console.ReadLine())!= "Season end")                                 //playerName ,      //positon  //skill
            {
                
                
                if (line.Contains("->"))//"{player} -> {position} -> {skill}" // when we introduce a new character or existing one
                {
                    string[] inputTokens = line.Split(" -> ").ToArray();
                    string playerName = inputTokens[0];
                    string position = inputTokens[1];
                    int skill = int.Parse(inputTokens[2]);

                    if (!playerNamePositionSkill.ContainsKey(playerName))//if there are not player with this name
                    {
                        playerNamePositionSkill[playerName] = new Dictionary<string, int>();
                        playerNamePositionSkill[playerName][position] = skill;

                    }
                    else // if there are existing one and we should compare the skill at the position
                    {
                        if (playerNamePositionSkill[playerName].ContainsKey(position))//if player have skill on the position
                        {
                            int lastPointSkill = playerNamePositionSkill[playerName][position];
                            if(skill >= lastPointSkill)
                            {
                                playerNamePositionSkill[playerName][position] = skill;
                                continue;
                            }
                            continue;
                        }
                        else
                        {
                            playerNamePositionSkill[playerName][position] = skill;
                        }

                    }
                    
                }
                else //"{player} vs {player}" //When it is a war
                {
                    string[] inputTokens = line.Split(" vs ").ToArray();
                    string firstPlayer = inputTokens[0];
                    string secondPlayer = inputTokens[1];

                    if (!playerNamePositionSkill.ContainsKey(firstPlayer))
                    {
                        continue;
                    }
                    if (!playerNamePositionSkill.ContainsKey(secondPlayer))
                    {
                        continue;
                    }

                    List<string> firstPlayerPositions = playerNamePositionSkill[firstPlayer].Keys.ToList();
                    List<string> secondPlayerPositions = playerNamePositionSkill[secondPlayer].Keys.ToList();
                    List<string> commonPositions = firstPlayerPositions.Intersect(secondPlayerPositions).ToList();
                    if(commonPositions.Count <= 0)
                    {
                        continue;
                    }

                    foreach (string position in commonPositions)
                    {
                        int firstPlayerPositionSkill = playerNamePositionSkill[firstPlayer][position];
                        int secondPlayerPositionSkill = playerNamePositionSkill[secondPlayer][position];

                        if(firstPlayerPositionSkill > secondPlayerPositionSkill)
                        {
                            playerNamePositionSkill[secondPlayer].Remove(position);
                        }
                        else if(secondPlayerPositionSkill > firstPlayerPositionSkill)
                        {
                            playerNamePositionSkill[firstPlayer].Remove(position);
                        }
                        else if(firstPlayerPositionSkill == secondPlayerPositionSkill)
                        {
                            continue;
                        }

                    }

                }
                

            }

            //remove all the players with no positoins
            foreach (KeyValuePair<string,Dictionary<string,int>> playerNameWithCollection in playerNamePositionSkill)
            {
                if(playerNameWithCollection.Value.Count <= 0)
                {
                    playerNamePositionSkill.Remove(playerNameWithCollection.Key);
                }

            }

            //get the total skill points on each player
            Dictionary<string, int> playerNameSkill = new Dictionary<string, int>();
            foreach (KeyValuePair<string, Dictionary<string, int>> playerNameWithCollection in playerNamePositionSkill)
            {
                int totalSkill = 0;
                playerNameSkill[playerNameWithCollection.Key] = totalSkill;
                foreach (KeyValuePair<string,int> positionSkill in playerNameWithCollection.Value)
                {
                    playerNameSkill[playerNameWithCollection.Key] += positionSkill.Value;

                }

            }

            //players, ordered by total skill in descending order, then ordered by player name in ascending order.
            playerNameSkill = playerNameSkill.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary();
            //Foreach player print their position and skill, ordered descending by skill, then ordered by position name in ascending order
            

            /*
            //print each player and his skill
            foreach (KeyValuePair<string, Dictionary<string, int>> playerNameWithCollection in playerNamePositionSkill)
            {
                Console.WriteLine($"{playerNameSkill}: {playerNameSkill[playerNameWithCollection.Key]} skill");
                foreach (KeyValuePair<string,int> positinoSkill in playerNameWithCollection.Value)
                {
                    Console.WriteLine($"- {positinoSkill.Key} <::> {positinoSkill.Value}");

                }
            }
             */

            foreach (KeyValuePair<string,int> playerAndSkill in playerNameSkill)
            {
                Console.WriteLine($"{playerAndSkill.Key}: {playerAndSkill.Value} skill");
                

                foreach (var positionSkill in playerNamePositionSkill[playerAndSkill.Key])
                {
                    playerNamePositionSkill[playerAndSkill.Key] = playerNamePositionSkill[playerAndSkill.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary();
                    
                }
                foreach (var positionSkill in playerNamePositionSkill[playerAndSkill.Key])
                {
        
                    Console.WriteLine($"- {positionSkill.Key} <::> {positionSkill.Value}");
                }

            }

        }
    }
}
