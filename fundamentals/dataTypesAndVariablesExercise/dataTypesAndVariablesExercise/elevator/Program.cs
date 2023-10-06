using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int courses = 0;

            while(countPeople > 0)
            {
                countPeople = countPeople - elevatorCapacity;
                courses += 1;

            }

            Console.WriteLine(courses);

        }
    }
}
