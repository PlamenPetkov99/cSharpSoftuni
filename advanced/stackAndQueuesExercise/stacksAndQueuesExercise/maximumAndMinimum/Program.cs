namespace maximumAndMinimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "1")
                {
                    int elementToAdd = int.Parse(command[1]);
                    numbers.Push(elementToAdd);
                }
                else if (command[0] == "2")
                {
                    numbers.Pop();
                }
                else if (command[0] == "3")
                {
                    if(numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Max());

                    }
                }
                else if (command[0] == "4")
                {
                    if(numbers.Count > 0)
                    {

                        Console.WriteLine(numbers.Min());
                    }
                }

            }

            Console.WriteLine(string.Join(", ",numbers));


        }
    }
}
