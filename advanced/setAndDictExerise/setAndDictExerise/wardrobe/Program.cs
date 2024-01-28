namespace wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colorDressCount = new Dictionary<string, Dictionary<string, int>>();
            string[] separators = new string[2]{",", " -> " };
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                //"{color} -> {item1},{item2},{item3}…"

                string color = inputTokens[0];
                if (!colorDressCount.ContainsKey(color))
                {
                    colorDressCount[color] = new Dictionary<string, int>();   
                }
                for (int j = 1; j < inputTokens.Length; j++)
                {
                    string currentClothe = inputTokens[j];
                    if (!colorDressCount[color].ContainsKey(currentClothe))
                    {
                        colorDressCount[color][currentClothe] = 1;
                    }
                    else
                    {
                        colorDressCount[color][currentClothe]++;
                    }
                }


            }

            string[] searched = Console.ReadLine().Split();
            string searchedColor = searched[0];
            string searchedClothe = searched[1];

            foreach (var kvp in colorDressCount)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var kvp2 in kvp.Value)
                {
                    if(kvp2.Key == searchedClothe && kvp.Key == searchedColor)
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value}");
                    }

                }
            }

            
        }
    }
}
