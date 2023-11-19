namespace validUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ").ToArray();

           

            foreach (string word in words) //lenght
            {
                bool isValid = false;
                if(3 < word.Length && word.Length < 16)
                {
                    foreach (char character in word)
                    {
                        if(char.IsDigit(character) || char.IsLetter(character) || character == '-'|| character == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }

                    }
                    if (isValid)
                    {
                        Console.WriteLine(word);
                    }
                }


            }


        }
    }
}
