namespace rankingg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string ,string> contestAndPassword = new Dictionary<string, string>();
            List<User> listWithUsers = new List<User>();


            string line = string.Empty;
            while ((line = Console.ReadLine())!= "end of contests") //getting contests and passwords
            {
                string[] inputTokens = line.Split(":").ToArray();
                //"{contest}:{password for contest}", 
                string contestName = inputTokens[0];
                string contestPassword = inputTokens[1];

                contestAndPassword[contestName] = contestPassword;

            }

            string inputLine = string.Empty;
            while((inputLine = Console.ReadLine())!= "end of submissions")
            {
                string[] inputTokens = inputLine.Split("=>").ToArray();
                //"{contest}=>{password}=>{username}=>{points}"

                string currentContestName = inputTokens[0];
                string currentContestPassword = inputTokens[1];
                string usernameOnFocus = inputTokens[2];
                int usernamePoints = int.Parse(inputTokens[3]);

                if (contestAndPassword.ContainsKey(currentContestName))//if contest exist
                {
                    if (contestAndPassword[currentContestName] == currentContestPassword) // if password is same as the original
                    {
                        User isUserFound = listWithUsers.Find(x => x.Name == usernameOnFocus);
                        if (isUserFound != null)
                        {
                            if (isUserFound.ContestWithPoints.ContainsKey(currentContestName))
                            {
                                int lastTimePoints = isUserFound.ContestWithPoints[currentContestName];
                                if(lastTimePoints <= usernamePoints)
                                {
                                    isUserFound.ContestWithPoints[currentContestName] = usernamePoints;
                                    continue;
                                }
                                continue;
                            }

                            isUserFound.ContestWithPoints[currentContestName] = usernamePoints;

                        }
                        else
                        {
                            User user = new User(usernameOnFocus);
                            user.ContestWithPoints[currentContestName] = usernamePoints;
                            listWithUsers.Add(user);

                        }
                        
                        
                    }
                }

            }

            int maxPoints = int.MinValue;
            string userWithMaxPoints = string.Empty;
            
            foreach (User user in listWithUsers)
            {
                int currentTotal = 0;

                foreach (KeyValuePair<string,int> kvp in user.ContestWithPoints)
                {
                    currentTotal += kvp.Value;

                }    

                if(maxPoints <= currentTotal)
                {
                    maxPoints = currentTotal;
                    userWithMaxPoints = user.Name;
                }

            }

            Console.WriteLine($"Best candidate is {userWithMaxPoints} with total {maxPoints} points.");

            Console.WriteLine("Ranking:");

            listWithUsers = listWithUsers.OrderBy(x => x.Name).ToList();


            foreach (User user in listWithUsers)
            {
                Console.WriteLine(user.Name);
                user.ContestWithPoints = user.ContestWithPoints.OrderByDescending(x => x.Value).ToDictionary(x=> x.Key , x => x.Value);

                foreach (var kvp in user.ContestWithPoints)
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }







        }

        public class User
        {
            public string Name { get; set; }
            public Dictionary<string, int> ContestWithPoints { get; set; }

            public User()
            {

            }

            public User(string name)
            {
                Name = name;
                ContestWithPoints = new Dictionary<string, int>();
            }


        }
    }
}
