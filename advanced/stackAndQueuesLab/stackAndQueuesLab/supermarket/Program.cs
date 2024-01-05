
namespace supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string commandOrName = string.Empty;
            Queue<string> names = new Queue<string>();
            while((commandOrName = Console.ReadLine())!= "End")
            {
                if(commandOrName == "Paid")
                {
                    Paid(names);
                }
                else //if it is name
                {
                    names.Enqueue(commandOrName);
                }

            }

            Console.WriteLine($"{names.Count} people remaining.");

        }

        private static void Paid(Queue<string> queque)
        {
            for(int i = 0; i < queque.Count;)
            {
                string currentName = queque.Dequeue();
                Console.WriteLine(currentName);
            }
        }
    }
}
