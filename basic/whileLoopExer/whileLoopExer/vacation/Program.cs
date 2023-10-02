using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double moneyForNow = double.Parse(Console.ReadLine());
            int countDays = 0;
            int spendDays = 0;
            bool EnoughMoney = false;
            bool tooMuchSpend = false;

            while (moneyForNow >= 0)
            {
                string command = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                switch (command)
                {
                    case "spend":
                        moneyForNow = moneyForNow - currentMoney;
                        spendDays = spendDays + 1;
                        countDays = countDays + 1;
                        if (moneyForNow < 0)
                        {
                            moneyForNow = 0;
                        }
                        break;
                    case "save":
                        moneyForNow = moneyForNow + currentMoney;
                        spendDays = 0;
                        countDays = countDays + 1;
                        break;
                }
                if (spendDays >= 5)
                {
                    tooMuchSpend = true;
                    break;
                }
                if (moneyForNow >= neededMoney)
                {
                    EnoughMoney = true;
                    break;
                }
            }

            if (EnoughMoney)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
            else if(tooMuchSpend)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countDays);
                  
            }



        }
    }
}
