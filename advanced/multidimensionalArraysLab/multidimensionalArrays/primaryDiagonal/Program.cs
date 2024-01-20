namespace primaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowCol, rowCol];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col]; ;
                }
            }

            int sumDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(row == col)
                    {
                        sumDiagonal += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sumDiagonal);

        }
    }
}
