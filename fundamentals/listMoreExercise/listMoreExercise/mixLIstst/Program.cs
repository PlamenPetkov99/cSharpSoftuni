namespace mixLIstst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mixList = new List<int>();
            List<int> constrains = new List<int>();

            secondInput.Reverse();

            while(firstInput.Count > 0 && secondInput.Count > 0)
            {
                mixList.Add(firstInput[0]);
                mixList.Add(secondInput[0]);
                firstInput.RemoveAt(0);
                secondInput.RemoveAt(0);
            }
            
            if(firstInput.Count > 0)
            {
                for (int i = 0; i < firstInput.Count; i++)
                {
                    constrains.Add(firstInput[i]);
                }
            }
            else if(secondInput.Count > 0)
            {
                for (int i = 0; i < secondInput.Count; i++)
                {
                    constrains.Add(secondInput[i]);
                }
            }

            int biggerConstrain = constrains.Max();
            int smallerConstrain = constrains.Min();

            List<int> result = new List<int>();

            for (int i = 0; i < mixList.Count; i++)
            {
                int currentNumber = mixList[i];

                if(smallerConstrain < currentNumber && currentNumber < biggerConstrain)
                {
                    result.Add(currentNumber);
                }
            }

            result = result.OrderBy(x=> x).ToList();
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
