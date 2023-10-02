using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());
            double studioCost = 0;
            double apartmentCost = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioCost = 50;
                    apartmentCost = 65;
                    break;

                case "June":
                case "September":
                    studioCost = 75.20 ;
                    apartmentCost = 68.70 ;
                    break;

                case "July":
                case "August":
                    studioCost = 76 ;
                    apartmentCost = 77 ;
                    break;


            }
            
            if ((month == "May") || (month == "October"))
            {
                if (countNights > 14)
                {

                    studioCost = studioCost - (studioCost * 0.30);
                }
                else if(countNights > 7)
                {

                    studioCost = studioCost - (studioCost * 0.05);
                }
            }
            
            if ((month == "June") || (month == "September"))
            {
                if (countNights > 14)
                {
                    studioCost = studioCost - (studioCost * 0.20);
                }
            }

            if (countNights > 14)
            {
                apartmentCost = apartmentCost - (apartmentCost * 0.10);
            }


            double totalStudio = countNights * studioCost;
            double totalApartment = countNights * apartmentCost;

            Console.WriteLine($"Apartment: {totalApartment,0:F2} lv.");
            Console.WriteLine($"Studio: {totalStudio,0:F2} lv.");
        }
    }
}
