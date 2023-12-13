using System.Diagnostics;

namespace speedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            
            for (int i = 0; i < n; i++)
            {
                string[] inputLineAr = Console.ReadLine().Split().ToArray();
                string model = inputLineAr[0];
                decimal fuel = decimal.Parse(inputLineAr[1]);
                decimal fuelConsumption = decimal.Parse(inputLineAr[2]);

                Car car = new Car(model,fuel,fuelConsumption);
                carList.Add(car);
            }

            string inputLine = string.Empty;

            while ((inputLine = Console.ReadLine())!= "End")
            {
                string[] line = inputLine.Split().ToArray();

                string modelWantedToDrive = line[1];
                decimal kmToDrive = decimal.Parse(line[2]);

                List<Car> wantedCar = carList.Where(x => x.Model == modelWantedToDrive).ToList();

                decimal currentFuel = wantedCar[0].FuelAmount;
                decimal neededFuel = wantedCar[0].FuelConsumptionPerKm * kmToDrive;
                if (currentFuel >= neededFuel ) 
                {
                    /*
                    foreach (Car car in carList)
                    {
                        if(car.Model == modelWantedToDrive)
                        {
                            car.FuelAmount -= neededFuel;
                            car.TraveledDistance += kmToDrive;
                        }

                    }
                    */
                    wantedCar[0].FuelAmount -= neededFuel;
                    wantedCar[0].TraveledDistance += kmToDrive;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }


            foreach (Car car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount,0:F2} {car.TraveledDistance}");
            }

        }
    }

    public class Car
    {
        public string Model { get; set; }

        public decimal FuelAmount { get; set; }
        public decimal FuelConsumptionPerKm { get; set; }
        public decimal TraveledDistance { get; set; }

        public Car(string model , decimal fuelAmount , decimal fuelConsumption) 
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumption;
            TraveledDistance = 0;

        }

        
    }
    
}
