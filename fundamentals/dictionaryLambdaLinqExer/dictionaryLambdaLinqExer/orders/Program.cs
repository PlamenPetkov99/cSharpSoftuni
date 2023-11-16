using System.Collections.Generic;

namespace orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{name} {price} {quantity}"
            //until "buy"

            string input = default;
            Dictionary<string, int> productWithQuantity = new Dictionary<string, int>();
            Dictionary<string,decimal> productWithPrice = new Dictionary<string, decimal>();    
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputTokens = input.Split().ToArray();
                string productName = inputTokens[0];
                decimal price = decimal.Parse(inputTokens[1]);
                int quantity = int.Parse(inputTokens[2]);

                if (!productWithQuantity.ContainsKey(productName))
                {
                    productWithQuantity[productName] = quantity;
                    productWithPrice[productName] = price;
                }
                else
                {
                    productWithPrice[productName] = price;
                    productWithQuantity[productName] += quantity;
                }
                             
            }

            //"{productName} -> {totalPrice,0:F2}"

            foreach (KeyValuePair<string,int> kvp in productWithQuantity)
            {
                string name = kvp.Key;
                decimal totalPrice = kvp.Value * productWithPrice[name];
                Console.WriteLine($"{name} -> {totalPrice,0:F2}");
            }

        }


    }
}