using System.Numerics;

namespace houseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCommands = int.Parse(Console.ReadLine());
            List<string> personsAtParty = new List<string>();
            string name = "";


            for (int i = 0; i < countCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if(command.Count > 3) //Allie is going!(count == 3) ==> when they will not go.
                {
                    name = command[0];
                    if (personsAtParty.Contains(name))
                    {
                        personsAtParty.Remove(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }

                }
                else
                {
                    name = command[0];
                    if (personsAtParty.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    else
                    {
                        personsAtParty.Add(name);
                    }
                }

            }

            foreach (var item in personsAtParty)
            {
                Console.WriteLine(item);
            }

        }
    }
}