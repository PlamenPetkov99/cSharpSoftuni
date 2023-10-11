using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] originalArray = Console.ReadLine().Split();
            string[] currentArray = new string[originalArray.Length];
            int rotation = int.Parse(Console.ReadLine());

            for (int rotationNumber = 0; rotationNumber < rotation; rotationNumber++)
            {
                
                currentArray[currentArray.Length - 1] = originalArray[0];

                for (int i = 1; i <= originalArray.Length-1; i++)
                {
                    currentArray[i - 1] = originalArray[i];

                }

                originalArray = (string[])currentArray.Clone();
                
            }

            Console.WriteLine(string.Join(" ",originalArray));

        }
    }
}
