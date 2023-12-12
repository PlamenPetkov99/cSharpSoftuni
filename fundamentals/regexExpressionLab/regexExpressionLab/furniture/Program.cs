using System.Text.RegularExpressions;

namespace furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex reg = new Regex(pattern);

            MatchCollection mC = reg.Matches(input);

            foreach (Match m in mC) 
            {
                Console.Write(m + " ");
            }





        }
    }
}
