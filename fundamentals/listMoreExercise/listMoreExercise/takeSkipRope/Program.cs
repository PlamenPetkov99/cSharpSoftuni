using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace takeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<int> numbersList = new List<int>();
            List<string> nonNumbersList = new List<string>();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    numbersList.Add(int.Parse(c.ToString()));
                }
                else
                {
                    nonNumbersList.Add(c.ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if(i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }

            }


            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < takeList.Count; i++)
            {
                int countSymbolsToTake = takeList[i];
                int countSymbolsToSkip = skipList[i];
                string currentTook = string.Empty;


                if(0 < countSymbolsToTake && countSymbolsToTake < nonNumbersList.Count)
                {
                    for (int j = 0; j < countSymbolsToTake; j++)
                    {
                        currentTook += nonNumbersList[j];
                    }
                    sb.Append(currentTook);
                    nonNumbersList.RemoveRange(0,countSymbolsToTake);
                    nonNumbersList.RemoveRange(0, countSymbolsToSkip);

                }
                else
                {
                    countSymbolsToTake = Math.Min(nonNumbersList.Count, countSymbolsToTake);
                    countSymbolsToSkip = Math.Min(nonNumbersList.Count - 1, countSymbolsToSkip);
                    for (int j = 0; j < countSymbolsToTake; j++)
                    {
                        currentTook += nonNumbersList[j];
                    }
                    sb.Append(currentTook);
                    nonNumbersList.RemoveRange(0,countSymbolsToTake);
                    nonNumbersList.RemoveRange(0, countSymbolsToSkip);

                }

            }

            Console.WriteLine(sb);
        }
    }
}
