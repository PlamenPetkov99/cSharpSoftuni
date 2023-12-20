namespace dragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<Dragon>> typeAndDragonCol = new Dictionary<string, List<Dragon>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //"{type} {name} {damage} {health} {armor}" there could be null Default:(health 250, damage 45 and armor 10)
                //  Red  Bazgargal 100     2500      25
                string[] inputTokens = Console.ReadLine().Split().ToArray();
                string type = inputTokens[0];
                string name = inputTokens[1];
                int damage;
                int health;
                int armor;
                if (inputTokens[2] == "null")//damage
                {
                     damage = 45;
                }
                else
                {
                    damage = int.Parse(inputTokens[2]);
                }
                if (inputTokens[3] == "null")//healht
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(inputTokens[3]);
                }
                if (inputTokens[4] == "null")//armor
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(inputTokens[4]);
                }

                Dragon currentDragon = new Dragon(type, name, damage, health, armor);

                if (!typeAndDragonCol.ContainsKey(type))
                {
                    typeAndDragonCol[type] = new List<Dragon>();
                    typeAndDragonCol[type].Add(currentDragon);
                }
                else
                {
                    Dragon isFoundDragon = typeAndDragonCol[type].Find(x => x.Name == name);

                    if(isFoundDragon == null)
                    {
                        typeAndDragonCol[type].Add(currentDragon);
                    }
                    else
                    {
                        isFoundDragon.Damage = damage;
                        isFoundDragon.Health = health;
                        isFoundDragon.Armor = armor;
                    }
                }
            }

            //dragons are sorted alphabetically by name

            List<string> dragonTypes = typeAndDragonCol.Keys.ToList();

            foreach (string type in dragonTypes)
            {
                typeAndDragonCol[type] = typeAndDragonCol[type].OrderBy(x => x.Name).ToList();

            }





            //print it
            foreach (KeyValuePair<string,List<Dragon>> typeAndCollectionOfDragonsForCurrentType in typeAndDragonCol)
            {
                decimal currentTypeAvgDmg = 0m;
                decimal currentTypeAvgHlth = 0m;
                decimal currentTypeAvgArmor = 0m;

                foreach (Dragon currentDragoon in typeAndCollectionOfDragonsForCurrentType.Value)
                {
                    currentTypeAvgDmg += currentDragoon.Damage;
                    currentTypeAvgHlth += currentDragoon.Health;
                    currentTypeAvgArmor += currentDragoon.Armor;
                }

                currentTypeAvgDmg = currentTypeAvgDmg / typeAndCollectionOfDragonsForCurrentType.Value.Count;
                currentTypeAvgHlth = currentTypeAvgHlth / typeAndCollectionOfDragonsForCurrentType.Value.Count;
                currentTypeAvgArmor = currentTypeAvgArmor / typeAndCollectionOfDragonsForCurrentType.Value.Count;

                Console.WriteLine($"{typeAndCollectionOfDragonsForCurrentType.Key}::({currentTypeAvgDmg,0:F2}/{currentTypeAvgHlth,0:F2}/{currentTypeAvgArmor,0:F2})");
                //"{Type}::({damage}/{health}/{armor})"
                foreach (Dragon currentDragoon in typeAndCollectionOfDragonsForCurrentType.Value)
                {
                    Console.WriteLine($"-{currentDragoon.Name} -> damage: {currentDragoon.Damage}, health: {currentDragoon.Health}, armor: {currentDragoon.Armor}");
                    //"-{Name} -> damage: {damage}, health: {health}, armor: {armor}"

                }
            }

        }
    }

    public class Dragon
    {
        //{type} {name} {damage} {health} {armor}
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragon(string type,string name,int dmg,int hlth,int armor)
        {
            Type = type;
            Name = name;
            Damage = dmg;
            Health = hlth;
            Armor = armor;
        }

    }
}
