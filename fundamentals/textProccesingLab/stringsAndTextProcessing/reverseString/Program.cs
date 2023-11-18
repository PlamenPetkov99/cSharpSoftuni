using System;
namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"end" 

            string word = default;

            while((word = Console.ReadLine())!= "end")
            {
                char[] wordArray = word.ToCharArray();
                char[] reversedWordArray = wordArray.Reverse().ToArray();
                Console.WriteLine($"{word} = {string.Join("",reversedWordArray)}");
                
            }
            


        }
    }
}
