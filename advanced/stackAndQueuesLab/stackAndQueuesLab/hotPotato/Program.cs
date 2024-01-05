namespace hotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kidsNames = Console.ReadLine().Split().ToArray();
            Queue<string> names = new Queue<string>();
            int n = int.Parse(Console.ReadLine());
            foreach(string name in kidsNames)
            {
                names.Enqueue(name);
            }

            while(names.Count > 1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    string curName = names.Dequeue();
                    names.Enqueue(curName);
                }
                string eleminatedName = names.Dequeue();
                Console.WriteLine($"Removed {eleminatedName}");
            }
            Console.WriteLine($"Last is {names.Dequeue()}");

        }
    }
}
