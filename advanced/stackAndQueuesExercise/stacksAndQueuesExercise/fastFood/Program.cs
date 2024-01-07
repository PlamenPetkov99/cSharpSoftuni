namespace fastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFoodForTheDay = int.Parse(Console.ReadLine());
            int[] quantityOfOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>();

            foreach(int quantOrder in quantityOfOrders)
            {
                ordersQueue.Enqueue(quantOrder);
            }

            Console.WriteLine(ordersQueue.Max());
            
            while (ordersQueue.Count > 0)
            {
                if(quantityFoodForTheDay < ordersQueue.Peek())
                {
                    break;
                }
                int currentOrder = ordersQueue.Dequeue();
                quantityFoodForTheDay -= currentOrder;

            }

            if(ordersQueue.Count <= 0)
            {

                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: "); Console.Write(string.Join(" ", ordersQueue));
            }


        }
    }
}
