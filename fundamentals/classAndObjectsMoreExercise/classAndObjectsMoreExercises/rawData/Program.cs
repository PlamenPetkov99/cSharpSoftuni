namespace rawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            
            for (int i = 0; i < n; i++)
            {
                //"<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>"
                string[] inputTokens = Console.ReadLine().Split().ToArray();
                string model = inputTokens[0];
                int engSpeed = int.Parse(inputTokens[1]);
                int engPower = int.Parse(inputTokens[2]);
                int cargoWeight = int.Parse(inputTokens[3]);
                string cargoType = inputTokens[4];

                Engine engine = new Engine(engSpeed, engPower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car currentCar = new Car(model, engine, cargo);
                cars.Add(currentCar);

            }

            string command = Console.ReadLine();//"fragile" or "flamable"

            if(command == "fragile")
            {
                List<Car> carsCargoTypeFragile = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000).ToList();
                foreach(Car car in carsCargoTypeFragile)
                {
                    Console.WriteLine(car.Model);
                }


            }
            else if(command == "flamable")
            {
                List<Car> carsCargoTypeFlamable = cars.Where(x => x.Cargo.CargoType == "flamable"&& x.Engine.EnginePower > 250).ToList();
                foreach(Car car in carsCargoTypeFlamable)
                {
                    Console.WriteLine(car.Model);
                }

            }

        }
    }

    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Car(string model , Engine engine , Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;

        }

    }

    public class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Cargo(int weight,string type)
        {
            CargoWeight = weight;
            
            CargoType = type;

        }
    }

    public class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int speed,int power)
        {
            EngineSpeed = speed;

            EnginePower = power;

        }

    }
}
