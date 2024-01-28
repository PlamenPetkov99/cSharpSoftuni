namespace jaggedArrayManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numberOfRows = int.Parse(Console.ReadLine());
            if(numberOfRows <= 0)
            {
                return;
            }
            long[][] matrix = new long[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++) // creating matrix and fill it with numbers
            {
                long[] newRow = Console.ReadLine().Split().Select(long.Parse).ToArray();
                matrix[i] = newRow;
            }

            for (int row = 0; row < matrix.Length-1; row++)//analyze
            {
                long currentRowLenght = matrix[row].Length;
                long belowRowLenght = matrix[row + 1].Length;

                if(currentRowLenght == belowRowLenght) //multiply by 2
                {
                    for (int j = 0; j < currentRowLenght; j++)
                    {
                        matrix[row][j] *= 2;
                        matrix[row+1][j] *= 2;
                        
                    }
                }
                else // divide by 2
                {
                    for (int j = 0; j < currentRowLenght; j++)
                    {
                        matrix[row][j] /= 2;

                    }
                    for (int k = 0; k < belowRowLenght; k++)
                    {
                        matrix[row + 1][k] /= 2;

                    }
                }

            }

            string inputLine = string.Empty;
            while((inputLine = Console.ReadLine()) != "End")
            {
                string[] inputTokens = inputLine.Split().ToArray();//•	"Add {row} {column} {value}" , •	"Subtract {row} {column} {value}"

                string command = inputTokens[0];
                int row = int.Parse(inputTokens[1]);
                int column = int.Parse(inputTokens[2]);
                long value = long.Parse(inputTokens[3]);
                
                if(row < 0 || column < 0 || matrix.Length < row || matrix.Length < 0 )
                {
                    continue;
                }

                if (matrix[row].Length < column || matrix[row].Length < 0)
                {
                    continue;
                }
                if(command == "Add")
                {
                    matrix[row][column] += value;
                }
                else if(command == "Subtract")
                {
                    matrix[row][column] -= value;
                }
                
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
            

        }
    }
}
