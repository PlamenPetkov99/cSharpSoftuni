using System.Text.RegularExpressions;

namespace furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = default;
            decimal totalPrice = 0;
            string pattern = @">>(?<furnitureName>[A-z]+|[A-Za-z]+\s[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<quantity>\d+)";
            Regex reg = new Regex(pattern);
            List<string> boughtFurniture = new List<string>();
         
            while((input = Console.ReadLine()) != "Purchase")
            {
                Match currentMatch = reg.Match(input);
                if (reg.IsMatch(input))
                {

                    string furnitureName = currentMatch.Groups["furnitureName"].Value;
                    decimal currentPrice = decimal.Parse(currentMatch.Groups["price"].Value);
                    decimal quantity = decimal.Parse(currentMatch.Groups["quantity"].Value);

                    decimal currentTotal = currentPrice * quantity;
                    totalPrice = totalPrice + currentTotal;
                    boughtFurniture.Add(furnitureName);
                }
            }

            Console.WriteLine("Bought furniture:");
            Console.Write(string.Join("\n",boughtFurniture));
            Console.WriteLine();
            Console.WriteLine($"Total money spend: {totalPrice,0:F2}");
        }
    }
}
