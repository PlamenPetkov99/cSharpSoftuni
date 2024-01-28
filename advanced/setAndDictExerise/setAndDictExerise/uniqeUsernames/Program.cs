﻿namespace uniqeUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }
            
            foreach(string name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
