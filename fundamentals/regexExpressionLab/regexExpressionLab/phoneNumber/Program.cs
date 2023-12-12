using System.Text.RegularExpressions;

namespace phoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\d+([\s|-])\d\1\d{3}\1\d{4}\b";
            Regex reg = new Regex(pattern);
            string input = Console.ReadLine();

            MatchCollection mc = reg.Matches(input);
            var phones = mc.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",phones));


        }
    }
}
