namespace treasure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> keys = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = string.Empty;
            while((line = Console.ReadLine())!= "find")
            {
                string cryptedMessage = line;
                string decryptedMessage = string.Empty;
                List<char> listWithCharactersCryptedMes = cryptedMessage.ToCharArray().ToList();
                while(listWithCharactersCryptedMes.Count >= 0)
                {
                    foreach (int key in keys)
                    {
                        if(listWithCharactersCryptedMes.Count <= 0)
                        {
                            break;
                        }

                    }
                }

            }
            



        }
    }
}
