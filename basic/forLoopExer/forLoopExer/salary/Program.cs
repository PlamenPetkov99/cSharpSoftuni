using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteration = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            bool isSalaryLost = false;

            for (int i = 0; i < iteration; i++)
            {
                

                string website = Console.ReadLine();
                switch (website)
                {
                    case "Facebook":
                        salary = salary - 150;
                        break;
                    case "Instagram":
                        salary = salary - 100;
                        break;
                    case "Reddit":
                        salary = salary - 50;
                        break;
                }
                if (salary <= 0)
                {
                    isSalaryLost = true;
                    break;
                }

            }

            if (isSalaryLost == true)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }


        }
    }
}