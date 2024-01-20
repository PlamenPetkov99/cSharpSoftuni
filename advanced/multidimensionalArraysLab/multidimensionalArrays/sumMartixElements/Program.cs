namespace sumMartixElements
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

            Console.WriteLine(rowCol[0]);
            Console.WriteLine(rowCol[1]);

            int sum = 0;
            foreach(int element in matrix)
            {
                sum += element;
            }
            Console.WriteLine(sum);

        }
    }
}
