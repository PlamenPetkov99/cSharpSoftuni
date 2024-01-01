namespace extractPersonalInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string sentence = Console.ReadLine();
                string name;//'@' and '|'
                string age;//'#' and '*'
                int startNameIndex = sentence.IndexOf("@");
                int endIndexName = sentence.IndexOf("|");
                int nameLenght = endIndexName - startNameIndex - 2;
                int startAgeIndex = sentence.IndexOf("#");
                int endAgeIndex = sentence.IndexOf("*");
                int ageLenght = endAgeIndex - startAgeIndex - 2;
                name = sentence.Substring(startNameIndex+1, nameLenght+1);
                age = sentence.Substring(startAgeIndex+1, ageLenght+1);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
