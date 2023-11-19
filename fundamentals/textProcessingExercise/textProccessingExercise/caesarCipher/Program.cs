namespace caesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //shifting each character with three positions forward , with letter wich on 3 position
            //input:Programming is cool!
            char[] input = Console.ReadLine().ToCharArray();
            //string lastSymbol = input[input.Length - 1].ToString();
            //List<string> inputTokens = input.Split().ToList(); //[Programming,is,cool,!]
            //inputTokens.Add(lastSymbol);
            string result ="";
            
            foreach (char currentCharacter in input)
            {
                char shiftedCharacter = (char)(currentCharacter + 3);
                result += shiftedCharacter;
            }
            

            Console.WriteLine(result);


        }
    }
}
