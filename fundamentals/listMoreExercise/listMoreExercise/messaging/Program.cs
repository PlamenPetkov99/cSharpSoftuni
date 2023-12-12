using System.Text;

namespace messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<char> text = Console.ReadLine().ToList();
            StringBuilder sb = new StringBuilder();

            foreach (int number in numbers)
            {
                string numberString = number.ToString();
                int currentTotal = 0;
                foreach (char digit in numberString)
                {
                    int currentNumber = int.Parse(digit.ToString());
                    currentTotal += currentNumber;
                }
                
                while(currentTotal > text.Count)
                {
                    currentTotal = currentTotal - text.Count;
                }

                sb.Append(text[currentTotal]);
                text.RemoveAt(currentTotal);
                

            }

            Console.WriteLine(sb);

        }
    }
}
