namespace snowWhite
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<string, Dictionary<string, int>> hatColorDwarfNameDwarfPhysic = new Dictionary<string, Dictionary<string, int>>();
            string line = string.Empty;
            while ((line = Console.ReadLine())!= "Once upon a time")
            {
                //"{dwarfName} <:> {dwarfHatColor} <:> {dwarfPhysics}"
                string[] inputTokens = line.Split(" <:> ").ToArray();
                string dwarfName = inputTokens[0];
                string dwarfHatColor = inputTokens[1];
                int dwarfPhysics = int.Parse(inputTokens[2]);

                if (hatColorDwarfNameDwarfPhysic.ContainsKey(dwarfHatColor))
                {
                    if (hatColorDwarfNameDwarfPhysic[dwarfHatColor].ContainsKey(dwarfName))
                    {
                        int lastTimeDwarfPhysic = hatColorDwarfNameDwarfPhysic[dwarfHatColor][dwarfName];

                        if(dwarfPhysics >= lastTimeDwarfPhysic)
                        {
                            hatColorDwarfNameDwarfPhysic[dwarfHatColor][dwarfName] = dwarfPhysics;
                        }
                        else
                        {
                            continue;
                        }
                        
                    }
                    else
                    {
                        hatColorDwarfNameDwarfPhysic[dwarfHatColor][dwarfName] = dwarfPhysics;
                    }
                }
                else
                {
                    hatColorDwarfNameDwarfPhysic[dwarfHatColor] = new Dictionary<string, int>();
                    hatColorDwarfNameDwarfPhysic[dwarfHatColor][dwarfName] = dwarfPhysics;
                }

            }

            //order the dwarfs by physics in descending order
            //and then by the total count of dwarfs with the same hat color in descending order. 

            List<string> dwarfHatColors = hatColorDwarfNameDwarfPhysic.Keys.ToList();
            foreach (string color in dwarfHatColors)
            {
                hatColorDwarfNameDwarfPhysic[color] = hatColorDwarfNameDwarfPhysic[color].OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
                hatColorDwarfNameDwarfPhysic = hatColorDwarfNameDwarfPhysic.OrderByDescending(x => x.Value.ToList().Count()).ToDictionary(x=>x.Key,x=>x.Value);

            }

            Dictionary<string, int> hatColorTotalPhysic = new Dictionary<string, int>();
            foreach (var colorAndColl in hatColorDwarfNameDwarfPhysic)
            {
                foreach (var dwarfNameAndPhysic in colorAndColl.Value)
                {
                    if (!hatColorTotalPhysic.ContainsKey(colorAndColl.Key))
                    {
                        hatColorTotalPhysic[colorAndColl.Key] = dwarfNameAndPhysic.Value;
                    }
                    else
                    {
                        hatColorTotalPhysic[colorAndColl.Key] += dwarfNameAndPhysic.Value;
                    }

                }

            }

            //and then by the total count of dwarfs with the same hat color in descending order. 
            hatColorTotalPhysic = hatColorTotalPhysic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);


            foreach (var currentColor in hatColorTotalPhysic)
            {
                //"({hatColor}) {name} <-> {physics}"
                foreach (var dwarfNameAndPhysic in hatColorDwarfNameDwarfPhysic[currentColor.Key])
                {
                    Console.WriteLine($"({currentColor.Key}) {dwarfNameAndPhysic.Key} <-> {dwarfNameAndPhysic.Value}");
                }
            }

            // 70/100 Should rework it !!
        }
    }
}
