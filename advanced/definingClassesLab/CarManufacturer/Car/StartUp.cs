using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string input = string.Empty;
            List<Tire[]> tires = new List<Tire[]>();
            while((input = Console.ReadLine())!= "No more tires")
            {
                string[] inputTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int year = int.Parse(inputTokens[0]);
                double pressure = double.Parse(inputTokens[1]);
                Tire[] tiresAr = new Tire[4]
                {
                    new Tire(int.Parse(inputTokens[0]), double.Parse(inputTokens[1])),
                    new Tire(int.Parse(inputTokens[2]), double.Parse(inputTokens[3])),
                    new Tire(int.Parse(inputTokens[4]), double.Parse(inputTokens[5])),
                    new Tire(int.Parse(inputTokens[6]), double.Parse(inputTokens[7])),
                };
                tires.Add(tiresAr);
                
            }

            List<Engine> engines = new List<Engine>();
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] inputTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int horsePower = int.Parse(inputTokens[0]);
                double cubicCapacity = double.Parse(inputTokens[1]);
                Engine engine = new Engine(horsePower,cubicCapacity);
                engines.Add(engine);
            }


            List<Car> cars = new List<Car>();
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] inputTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string make = inputTokens[0];
                string model = inputTokens[1];
                int year = int.Parse(inputTokens[2]);
                double fuelQuantity = double.Parse(inputTokens[3]);
                double fuelConsumption = double.Parse(inputTokens[4]);
                int engineIndex = int.Parse(inputTokens[5]);
                int tireIndex = int.Parse(inputTokens[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);
                cars.Add(car);
            }

            foreach (Car currentCar in cars)
            {
                currentCar.Drive(0.20);
            }





            Func<Car, double> getPressureSum = car =>
            {
                double sum = 0;
                foreach (var tire in car.Tires)
                {
                    sum += tire.Pressure;
                }
                return sum;
            };

            Func<Car, bool> predicate = car =>
            {
                double currentCarPressure = getPressureSum(car);
                bool isValidPressure = 9 <= currentCarPressure && currentCarPressure <= 10;
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && isValidPressure )
                {
                    return true;
                }

                return false;
            };
            
            
            cars = cars.Where(car => predicate(car)).ToList();

            foreach (Car curCar in cars)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Make: {curCar.Make}");
                sb.AppendLine($"Model: {curCar.Model}");
                sb.AppendLine($"Year: {curCar.Year}");
                sb.AppendLine($"HorsePowers: {curCar.Engine.HorsePower}");
                sb.AppendLine($"FuelQuantity: {curCar.FuelQuantity}");

                Console.WriteLine(sb.ToString().TrimEnd());
            }



        }
    }
}

