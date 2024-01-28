namespace snakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            string word = Console.ReadLine();

            int index = 0;

            string[,] matrix = new string[rows,cols];
            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if(row%2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row,col] = word[index].ToString();
                        index++;
                        if(index >= word.Length)
                        {
                            index = 0;
                        }
                    }

                }
                else
                {
                    for (int revCol = matrix.GetLength(1) - 1; revCol >= 0; revCol--)
                    {
                        matrix[row, revCol] = word[index].ToString();
                        index++;
                        if (index >= word.Length)
                        {
                            index = 0;
                        }
                    }

                }



            }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i,j]);
                    }
                    Console.WriteLine();
                }

        }
    }
}
