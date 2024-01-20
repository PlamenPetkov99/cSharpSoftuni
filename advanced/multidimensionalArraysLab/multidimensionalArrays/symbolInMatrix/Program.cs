namespace symbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int rowCol = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowCol, rowCol];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] charArray = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = charArray[col];
                }
            }
            char searchedCharacter = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == searchedCharacter)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{searchedCharacter} does not occur in the matrix");




        }
    }
}
