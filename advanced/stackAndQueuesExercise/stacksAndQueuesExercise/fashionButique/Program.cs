namespace fashionButique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothesValuesStack = new Stack<int>();
            int capacityOfOneRack = int.Parse(Console.ReadLine());
            int countRacks = 0;

            foreach(int value in clothesValues)
            {
                clothesValuesStack.Push(value);
            }

            //While the sum of the clothes is less than the capacity
            int currentSum = 0;
            int countRack = 0;
            int currentClothe = 0;
            
            while(clothesValuesStack.Count > 0)
            {
                while(currentSum < capacityOfOneRack)
                {
                    if(clothesValuesStack.Count <= 0)
                    {
                        break;
                    }
                    currentClothe = clothesValuesStack.Pop();
                    currentSum += currentClothe;
                }
                if(currentSum == capacityOfOneRack)
                {
                    currentSum = 0;
                    countRack += 1;
                }
                if(currentSum > capacityOfOneRack)
                {
                    currentSum = currentClothe;
                    countRack += 1;
                }

            }
            if(currentSum > 0)
            {
                countRack += 1;
            }

            Console.WriteLine(countRack);



        }
    }
}
