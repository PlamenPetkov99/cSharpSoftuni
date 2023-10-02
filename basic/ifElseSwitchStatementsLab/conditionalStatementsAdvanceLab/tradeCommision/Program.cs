using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tradeCommision
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0;
            bool isValidSales = true;
            bool isValidCity = true;

            if (sales < 0)
            {
                isValidSales = false;
                Console.WriteLine("error");
            }
            else
            {
                if (city == "Sofia")
                {
                    if ((0 <= sales) && (sales <= 500))
                    {
                        commision = 0.05;
                    }
                    else if ((500 < sales) && (sales <= 1000))
                    {
                        commision = 0.07;
                    }
                    else if ((1000 < sales) && (sales <= 10000))
                    {
                        commision = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.12;
                    }
                }
                else if (city == "Varna")
                {
                    if ((0 <= sales) && (sales <= 500))
                    {
                        commision = 0.045;
                    }
                    else if ((500 < sales) && (sales <= 1000))
                    {
                        commision = 0.075;
                    }
                    else if ((1000 < sales) && (sales <= 10000))
                    {
                        commision = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.13;
                    }
                }
                else if (city == "Plovdiv")
                {
                    if ((0 <= sales) && (sales <= 500))
                    {
                        commision = 0.055;
                    }
                    else if ((500 < sales) && (sales <= 1000))
                    {
                        commision = 0.08;
                    }
                    else if ((1000 < sales) && (sales <= 10000))
                    {
                        commision = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.145;
                    }
                }
                else
                {
                    isValidCity = false;
                    Console.Write("error");
                }


            }

            if ((isValidSales == true) && (isValidCity == true))
            {
                double total = sales * commision;
                Console.Write($"{total,0:F2}");
            }


        }
    }
}
