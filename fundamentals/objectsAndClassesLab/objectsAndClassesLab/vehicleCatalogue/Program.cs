using System.Reflection.Metadata;

namespace vehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = default;


            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            Catalog ca = new Catalog();
            

            while ((input = Console.ReadLine())!= "end")
            {

                //"{type}/{brand}/{model}/ {horse power / weight}"
                string[] tokens = input.Split("/").ToArray();
                Car car = new Car();
                Truck truck = new Truck();

                if (tokens[0] == "Car")
                {
                    car.Brand = tokens[1];
                    car.Model = tokens[2];
                    car.HorsePower = int.Parse(tokens[3]);

                    cars.Add(car);
                    
                    
                }
                else if (tokens[0] == "Truck")
                {
                    truck.Brand = tokens[1];
                    truck.Model = tokens[2];
                    truck.Weight = int.Parse(tokens[3]);

                    trucks.Add(truck);
                    
                }


            }

           List<Car> sortedCars =  cars.OrderBy(x => x.Brand).ToList();
            List<Truck> sortedTrucks = trucks.OrderBy(x => x.Brand).ToList();
            
            if(cars.Count > 0)
            {
                    Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if(trucks.Count > 0)
            {
                    Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
    class Car 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }


    }
    class Truck 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Catalog 
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
    

}