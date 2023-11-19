namespace characterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            List<char> firstWord = words[0].ToList();
            List<char> secondWord = words[1].ToList();

            int sum = MethodWithTwoStrings(firstWord, secondWord);
            Console.WriteLine(sum);

        }

        public static int MethodWithTwoStrings(List<char> firstArray , List<char> secondArray)
        {
            int result = default;
            
            while(firstArray.Count > 0 && secondArray.Count > 0)
            {
                
                
                int currentSum = firstArray[0] * secondArray[0];
                result += currentSum;
                firstArray.RemoveAt(0);
                secondArray.RemoveAt(0);
                
                
            }
            
            if(firstArray.Count <= 0)
            {
                for (int i = 0; i < secondArray.Count; i++)
                {
                    result += secondArray[i];
                }
            }
            else
            {
                for (int i = 0; i < firstArray.Count; i++)
                {
                    result += firstArray[i];
                }
            }
            


            return result;
        }
    }
}
