using System.Reflection.Emit;
using System.Transactions;

namespace vehicleCatalogue
{
    internal class Program
    {
        /*
        truck Man red 200
        truck Mercedes blue 300
        End
        Ferrari
        Ford
        Man
        Close the Catalogue

         */
        static void Main(string[] args)
        {
            string input = default;
            List<Catalog> listCatalog = new List<Catalog>();
            while ((input = Console.ReadLine()) != "End")
            {
                //"{typeOfVehicle} {model} {color} {horsepower}"
                Catalog catalog = new Catalog();
                string[] inputTokens = input.Split().ToArray();
                catalog.Type = inputTokens[0];
                catalog.Model = inputTokens[1];
                catalog.Color = inputTokens[2];
                catalog.Horsepower = decimal.Parse(inputTokens[3]);

                listCatalog.Add(catalog);

            }

            string wantedModel = default;
            while((wantedModel = Console.ReadLine()) != "Close the Catalogue")
            {
                List<Catalog> toPrint = listCatalog.Where(x => x.Model == wantedModel).ToList();
                foreach (Catalog item in toPrint)
                {
                    string type = default;
                    if(item.Type == "car")
                    {
                        type = "Car";
                    }
                    else
                    {
                        type = "Truck";
                    }
                    Console.WriteLine($"Type: {type}");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Color: {item.Color}");
                    Console.WriteLine($"Horsepower: {item.Horsepower}");
                }
            }

            List<Catalog> listCars = listCatalog.Where(x => x.Type == "car").ToList();
            List<Catalog> listTrucks = listCatalog.Where(x => x.Type == "truck").ToList();
            decimal averageCar = 0;
            decimal averageTruck = 0;

            if(listCars.Count > 0)
            {
                foreach (Catalog car in listCars)
                {
                    averageCar = averageCar + car.Horsepower;
                }
                averageCar = averageCar / listCars.Count;
            }
            if(listTrucks.Count > 0)
            {
                foreach (Catalog truck in listTrucks)
                {
                    averageTruck = averageTruck + truck.Horsepower;
                }
                averageTruck = averageTruck / listTrucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCar,0:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruck,0:F2}.");




        }
    }

    class Catalog
    {
        public string Type { get; set; }

        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Horsepower { get; set; }



    }

        

    
    
    

    
    
    
}