using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            if(allNumbers.Count > 1)
            {
            for (int i = 0; i < Math.Ceiling((double)allNumbers.Count/2); i++)
            {
                allNumbers[i] = allNumbers[i] + allNumbers[allNumbers.Count - 1];
                allNumbers.RemoveAt(allNumbers.Count - 1);

            }

            }
            
            
            Console.WriteLine(string.Join(" ",allNumbers));
        }
    }
}
