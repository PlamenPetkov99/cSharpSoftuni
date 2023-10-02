using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summerClothes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int temperature = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            switch (time)
            {
                case "Morning":
                    if ((10 <= temperature) && (temperature <=18))
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if ((18 < temperature) && (temperature <= 24))
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if ((10 <= temperature) && (temperature <= 18))
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if ((18 < temperature) && (temperature <= 24))
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (temperature >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    if ((10 <= temperature) && (temperature <= 18))
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if ((18 < temperature) && (temperature <= 24))
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;




            }

            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");

        }
    }
}
