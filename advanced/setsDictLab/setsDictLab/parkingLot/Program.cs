namespace parkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            HashSet<string> numbers = new HashSet<string>();
            while((input = Console.ReadLine())!= "END")
            {
                string[] inputTokens = input.Split(", ");//"direction, carNumber"
                string direction = inputTokens[0];
                string carNumber = inputTokens[1];

                if(direction == "IN")
                {
                    numbers.Add(carNumber);
                }
                else if(direction == "OUT")
                {
                    numbers.Remove(carNumber);
                }
            }
            if(numbers.Count > 0)
            {

                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }

            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
