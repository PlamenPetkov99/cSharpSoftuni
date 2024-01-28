using System.Threading.Channels;

namespace maximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = rowCol[0];
            int col = rowCol[1];

            int[][] matrix = new int[row][];
            int bestRow = 0;
            int bestCol = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] currentRow = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[rows] = currentRow;
                
            }
            int biggestSum = int.MinValue;
            for (int rows = 0; rows < row - 2; rows++)
            {
                for (int cols = 0; cols < col - 2; cols++)
                {
                    int sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum += matrix[rows + i][ cols + j];
                        }
                    }

                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        bestRow = rows;
                        bestCol = cols;
                    }
                }

            }

            Console.WriteLine($"Sum = {biggestSum}");
            for (int i = bestRow; i < bestRow+3; i++)
            {
                for (int j = bestCol; j < bestCol+3; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]} {matrix[bestRow, bestCol + 2]}");
            //Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]} {matrix[bestRow + 1, bestCol + 2]}");
            //Console.WriteLine($"{matrix[bestRow + 2, bestCol]} {matrix[bestRow + 2, bestCol + 1]} {matrix[bestRow + 2, bestCol + 2]}");







        }
    }
}
