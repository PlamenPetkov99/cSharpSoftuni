using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int countCoins = 0;
            while (money > 0)
            {
                if (money >= 2.00M)
                {
                    money = money - 2.00M;
                    countCoins = countCoins + 1;
                    continue;
                }
                else if(money >= 1.00M)
                {
                    money = money - 1.00M;
                    countCoins = countCoins + 1;
                    continue;
                }
                else if (money >= 0.50M)
                {
                    money = money - 0.50M;
                    countCoins = countCoins + 1;
                    continue;
                }
                else if (money >= 0.20M)
                {
                    money = money - 0.20M;
                    countCoins = countCoins + 1;
                    continue;
                }
                else if (money >= 0.10M)
                {
                    money = money - 0.10M;
                    countCoins = countCoins + 1;
                    continue;
                }
                else if (money >= 0.05M)
                {
                    money = money - 0.05M;
                    countCoins = countCoins + 1;
                    continue;
                }
                else if (money >= 0.02M)
                {
                    money = money - 0.02M;
                    countCoins = countCoins + 1;
                    continue;
                }
                else if (money >= 0.01M)
                {
                    money = money - 0.01M;
                    countCoins = countCoins + 1;
                    continue;
                }

            }

            Console.WriteLine(countCoins);



        }
    }
}
