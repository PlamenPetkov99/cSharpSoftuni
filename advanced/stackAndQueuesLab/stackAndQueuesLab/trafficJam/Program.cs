namespace trafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> notPassed = new Queue<string>();
            Queue<string> passed = new Queue<string>();

            int countCarsThatCanPassAtGreen = int.Parse(Console.ReadLine());

            string car = string.Empty;
            while((car = Console.ReadLine())!= "end")
            {
                if(car == "green")
                {
                    int n = Math.Min(countCarsThatCanPassAtGreen, notPassed.Count);
                    for (int i = 0; i < n; i++)
                    {
                        string currentCar = notPassed.Dequeue();
                        Console.WriteLine($"{currentCar} passed!");
                        passed.Enqueue(currentCar);
                    }
                }
                else
                {
                    notPassed.Enqueue(car);
                }
            }
            Console.WriteLine($"{passed.Count} cars passed the crossroads.");

        }
    }
}
