using System.Text.RegularExpressions;

namespace treasure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> keys = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> decryptedMessages = new List<string>();

            string line = string.Empty;
            while((line = Console.ReadLine())!= "find")
            {
                string cryptedMessage = line;
                string decryptedMessage = string.Empty;
                List<char> listWithCharactersCryptedMes = cryptedMessage.ToCharArray().ToList();
                int keyNumber = 0;
                int keysCount = keys.Count;
                while(listWithCharactersCryptedMes.Count > 0)
                {
                    char currentSymbol = listWithCharactersCryptedMes[0];
                    if(keyNumber >= keysCount)
                    {
                        keyNumber = 0;
                    }
                    int currentKey = keys[keyNumber];
                    char decriptedSymbol = (char)((int)currentSymbol - currentKey);
                    decryptedMessage += decriptedSymbol;

                    listWithCharactersCryptedMes.RemoveAt(0);
                    keyNumber++;
                }
                decryptedMessages.Add(decryptedMessage);


                
            }

            // try to solve problem with regex : \b\&([A-Za-z]+)\&[A-Za-z]+\<([1-9A-Za-z0]+)\>
            string pattern = @"\b\&([A-Za-z]+)\&[A-Za-z]+\<([1-9A-Za-z0]+)\>";
            Regex regex = new Regex(pattern);

            foreach (string message in decryptedMessages) 
            {
                MatchCollection mc = regex.Matches(message);
                foreach (Match match in mc)
                {
                    Console.WriteLine($"Found {match.Groups[1]} at {match.Groups[2]}");
                }
            }



        }
    }
}
