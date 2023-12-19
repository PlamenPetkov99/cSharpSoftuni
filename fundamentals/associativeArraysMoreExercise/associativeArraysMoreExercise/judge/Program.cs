using System;

namespace judge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string line = string.Empty;
            Dictionary<string, Dictionary<string, int>> contestNameUsernamePoints = new Dictionary<string, Dictionary<string, int>>();
            //[contestName[username[points]]]
            while ((line = Console.ReadLine()) != "no more time")
            {
                string[] inputTokens = line.Split(" -> ").ToArray();
                //"{username} -> {contest} -> {points}"

                string username = inputTokens[0];
                string contestName = inputTokens[1];
                int currentPoints = int.Parse(inputTokens[2]);

                if(!contestNameUsernamePoints.ContainsKey(contestName)) 
                {
                    contestNameUsernamePoints[contestName] = new Dictionary<string, int>();
                    contestNameUsernamePoints[contestName][username] = currentPoints;

                }
                else
                {
                    // we should check if the given user was on that contest and if his points was better than the current.
                    if (contestNameUsernamePoints[contestName].ContainsKey(username))// if the user was on the contest, we should check the points.
                    {
                        int lastTimePoints = contestNameUsernamePoints[contestName][username];

                        if (lastTimePoints <= currentPoints)
                        {
                            contestNameUsernamePoints[contestName][username] = currentPoints;
                            continue;
                        }
                        continue;
                    }
                    else
                    {
                        contestNameUsernamePoints[contestName][username] = currentPoints;
                    }

                }


            }

            //ordered by points in descending order, then ordered by name in ascending order.

            List<string> nameOfTheContests = new List<string>();
            foreach (KeyValuePair<string,Dictionary<string,int>> kvp in contestNameUsernamePoints)
            {
                nameOfTheContests.Add(kvp.Key);
            }

            foreach (string nameOfContest in nameOfTheContests)
            {
                contestNameUsernamePoints[nameOfContest] = contestNameUsernamePoints[nameOfContest].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                //item.Value = item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            }

            
            foreach (KeyValuePair<string,Dictionary<string,int>> contest in contestNameUsernamePoints)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int position = 1;
                foreach (KeyValuePair<string,int> participant in contest.Value)
                {
                    //"{position}. {username} <::> {points}"
                    Console.WriteLine($"{position}. {participant.Key} <::> {participant.Value}");
                    position++;
                }
            }

            //Individual standings:
            Dictionary<string, int> userNameTotalPoints = new Dictionary<string, int>();
            foreach (KeyValuePair<string,Dictionary<string,int>> contestWithUsers in contestNameUsernamePoints)
            {
                foreach (KeyValuePair<string,int> participants in contestWithUsers.Value)
                {
                    string username = participants.Key;
                    int currentPoints = participants.Value;
                    if (!userNameTotalPoints.ContainsKey(username))
                    {
                        userNameTotalPoints[username] = currentPoints;
                    }
                    else
                    {
                        userNameTotalPoints[username] += currentPoints;
                    }
                }

            }

            //total points in descending order, and then by alphabetical order
            userNameTotalPoints = userNameTotalPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);

            Console.WriteLine("Individual standings:");
            int positionn = 1;
            foreach (KeyValuePair<string,int> user in userNameTotalPoints)
            {
                Console.WriteLine($"{positionn}. {user.Key} -> {user.Value}");
                positionn++;
            }

        }
    }

    
}
