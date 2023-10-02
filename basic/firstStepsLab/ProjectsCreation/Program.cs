using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countProjects = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need {countProjects*3} hours to complete {countProjects} project/s.");
        }
    }
}
