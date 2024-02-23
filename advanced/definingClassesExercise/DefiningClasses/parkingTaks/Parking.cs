using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public int Count {
            get => cars.Count; 
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public Parking(int capacity)
        {
            Capacity = capacity;
            cars = new List<Car>();

        }

        public string AddCar(Car Car)
        {
            Car isThereSameCar = Cars.Find(c => c.RegistrationNumber == Car.RegistrationNumber);
            if(isThereSameCar != null)
            {
                return("Car with that registration number, already exists!");
                
            }
            if(Cars.Count >= Capacity)
            {
                return("Parking is full!");
                
            }
            cars.Add(Car);
            return($"Successfully added new car {Car.Make} {Car.RegistrationNumber}");
            

        }

        public string RemoveCar(string RegistrationNumber)
        {
            Car carToRemove = Cars.Find(c => c.RegistrationNumber == RegistrationNumber);
            if(carToRemove == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            Cars.Remove(carToRemove);
            return $"Successfully removed {RegistrationNumber}";
            
        }

        public Car GetCar(string RegistrationNumber)
        {
            return Cars.Find(c => c.RegistrationNumber == RegistrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {

            //foreach (string regNumber in RegistrationNumbers)
            //{

            //    Car carToRemove = Cars.Find(c => c.RegistrationNumber == regNumber);
            //    if (carToRemove == null)
            //    {
            //    }
            //    Cars.Remove(carToRemove);
            //}

            Func<Car,List<string> ,bool> predicate = (car,List) => RegistrationNumbers.Contains(car.RegistrationNumber);

            Cars.RemoveAll(car=>predicate(car,RegistrationNumbers));
            

        }






    }
}
