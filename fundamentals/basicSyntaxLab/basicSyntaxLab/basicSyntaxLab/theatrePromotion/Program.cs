using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
   
            double price = 0;
            bool isNegative = false;

            switch (type)
            {
                case "Weekday":
                    if ((64 < age) && (age <= 122))
                    {
                        price = 12;
                    }
                    else if ((18 < age) && (age <= 64))
                    {
                        price = 18;
                    }
                    else if ((0 <= age) && (age <= 18))
                    {
                        price = 12;
                    }

                    else
                    {
                        isNegative = true;
                    }
                    break;
                case "Weekend":
                    if ((64 < age) && (age <= 122))
                    {
                        price = 15;
                    }
                    else if ((18 < age) && (age <= 64))
                    {
                        price = 20;
                    }
                    else if ((0 <= age) && (age <= 18))
                    {
                        price = 15;
                    }
                    else
                    {
                        isNegative = true;
                    }
                    break;
                case "Holiday":
                    if ((0 <= age) && (age <= 18))
                    {
                        price = 5;
                    }
                    
                    else if ((18 < age) && (age <= 64))
                    {
                        price = 12;
                    }
                    else if ((64 < age) && (age <= 122))
                    {
                        price = 10;
                    }
                    else
                    {
                        isNegative = true;
                    }
                    break;


            
                   

            }
            if (isNegative == false)
            {
                Console.WriteLine($"{price}$");

            }
            else
            {
                Console.WriteLine("Error!");
            }


        }
    }
}
