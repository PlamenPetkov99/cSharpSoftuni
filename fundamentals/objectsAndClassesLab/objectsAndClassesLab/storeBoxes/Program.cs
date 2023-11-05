namespace storeBoxes
{
    internal class Program
    {
        //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
        static void Main(string[] args)
        {
            string input = default;
            List<Box> boxList = new List<Box>();
            

            while ((input = Console.ReadLine()) != "end")
            {
                Item item = new Item();
                Box box = new Box();
                string[] tokens = input.Split().ToArray();

                box.SerialNumber = tokens[0];
                item.Name = tokens[1];
                box.Item = item;
                box.ItemQuantity = decimal.Parse(tokens[2]);
                item.Price = decimal.Parse(tokens[3]);
                box.PriceForBox = box.ItemQuantity * item.Price;
                boxList.Add(box);
            }

            List<Box> sort = boxList.OrderBy(x => x.PriceForBox).ToList();
            sort.Reverse();
            ;
            for (int i = 0; i < sort.Count; i++)
            {
                Console.WriteLine(sort[i].SerialNumber);
                Console.WriteLine($"-- {sort[i].Item.Name} - ${sort[i].Item.Price,0:F2}: {sort[i].ItemQuantity}");
                Console.WriteLine($"-- ${sort[i].PriceForBox,0:F2}");
            }



        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public decimal ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
    }
}