namespace setsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //just test
            int first = sizes[0];
            int second = sizes[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();


            

            for (int i = 0; i < first; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < second; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> final = new HashSet<int>();
            int[] firstAr = firstSet.ToArray();
            int[] secondAr = secondSet.ToArray();

            for (int i = 0; i < firstAr.Length; i++)
            {
                if (secondAr.Contains(firstAr[i]))
                {
                    final.Add(firstAr[i]);
                }
            }

            Console.WriteLine(string.Join(" ",final));

        }
    }
}
