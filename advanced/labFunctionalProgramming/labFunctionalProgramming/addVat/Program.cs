namespace addVat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> getVat = number => number * 0.20;
            double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(n => n + getVat(n)).ToArray();
            foreach (var price in prices)
            {
                Console.WriteLine($"{price,0:F2}");
            }

        }
    }
}
