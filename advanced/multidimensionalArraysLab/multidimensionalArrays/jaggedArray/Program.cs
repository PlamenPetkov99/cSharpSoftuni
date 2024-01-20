namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = currentRow;

            }

            string inputLine = string.Empty;
            while((inputLine = Console.ReadLine()) != "END")
            {
                string[] inputTokens = inputLine.Split().ToArray(); //Add 0 0 5 , Subtract 1 2 2
                // Add {row} {col} {value}

                string command = inputTokens[0];
                int row = int.Parse(inputTokens[1]);
                int col = int.Parse(inputTokens[2]);
                int value = int.Parse(inputTokens[3]);

                if (row < 0 || row >= jaggedArray.Length || jaggedArray[row].Length <= col || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if(command == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if(command == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));

            }


        }
    }
}
