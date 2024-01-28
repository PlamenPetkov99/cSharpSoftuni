namespace squareOfMatrixEqualChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            int count = 0;

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentRow = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    string currentCharacter = matrix[row, col].ToString();
                    if(currentCharacter == matrix[row,col+1] && currentCharacter == matrix[row+1, col] && currentCharacter == matrix[row + 1, col + 1])
                    {
                        count ++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
