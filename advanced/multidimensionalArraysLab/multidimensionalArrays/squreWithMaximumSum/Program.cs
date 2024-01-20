namespace squreWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowCol[0], rowCol[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int bestRow = 0;
            int bestCol = 0;
            long maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)//without last row
            {
                long total = 0;
                for (int col = 0; col < matrix.GetLength(1)-1; col++)//without last col
                {
                    total = matrix[row,col] + matrix[row,col+1] + matrix[row + 1, col] + matrix[row+1,col+1];
                    if(total > maxSum)
                    {
                        maxSum = total;
                        bestRow = row;
                        bestCol = col;
                    }
                }

            }

            Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow,bestCol+1]}");
            Console.WriteLine($"{matrix[bestRow+1, bestCol]} {matrix[bestRow+1, bestCol + 1]}");
            Console.WriteLine(maxSum);

        }
    }
}
