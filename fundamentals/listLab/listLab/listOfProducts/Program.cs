using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> vegi = new List<string>();
            for (int i = 0; i < n; i++)
            {
                vegi.Add(Console.ReadLine());
            }
            vegi.Sort();
            for (int i = 1; i <= vegi.Count; i++)
            {
                Console.WriteLine($"{i}.{vegi[i-1]}");
            }



        }
    }
}
