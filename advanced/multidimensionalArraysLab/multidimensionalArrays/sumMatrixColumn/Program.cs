namespace sumMatrixColumn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowCol[0], rowCol[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int[] sums = new int[rowCol[1]];

            for (int col = 0; col < matrix.GetLength(1); col++) //make row to col and col to row
            {
                int currentSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int currentNumber = matrix[row, col];
                    currentSum += currentNumber;
                }
                Console.WriteLine(currentSum);
            }

        }
    }
}
