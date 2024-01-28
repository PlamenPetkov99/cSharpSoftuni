namespace productShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopNameProductNamePrice = new Dictionary<string, Dictionary<string, double>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] inputTokens = input.Split(", ").ToArray();
                //"{shop}, {product}, {price}".
                // {key} ,{value{key}, {value}}
                string shopName = inputTokens[0];
                string productName = inputTokens[1];
                double productPrice = double.Parse(inputTokens[2]);

                if(!shopNameProductNamePrice.ContainsKey(shopName))
                {
                    shopNameProductNamePrice[shopName] = new Dictionary<string, double>();
                    shopNameProductNamePrice[shopName][productName] = productPrice;
                }
                else // if there is
                {
                    shopNameProductNamePrice[shopName][productName] = productPrice;
                }

            }
            //Your output must be ordered by shop name
            shopNameProductNamePrice = shopNameProductNamePrice.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            //must be in the format:
            //"{shop}->
            //Product: {product}, Price: {price}"

            foreach (var kvp in shopNameProductNamePrice)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var productPrice in kvp.Value)
                {
                    Console.WriteLine($"Product: {productPrice.Key}, Price: {productPrice.Value}");
                }

            }


        }
    }
}
