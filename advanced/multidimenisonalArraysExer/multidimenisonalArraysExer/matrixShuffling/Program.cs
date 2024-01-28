namespace matrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = rowCol[0];
            int cols = rowCol[1];

            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split().ToArray();
                matrix[row] = currentRow;   
            }


            string inputLine = string.Empty;
            while((inputLine = Console.ReadLine()) != "END")
            {
                string[] inputTokens = inputLine.Split().ToArray();//"swap row1 col1 row2 col2"
                if(inputTokens.Contains("swap") && inputTokens.Length == 5)
                {
                    int row1 = int.Parse(inputTokens[1]);
                    int col1 = int.Parse(inputTokens[2]);
                    int row2 = int.Parse(inputTokens[3]);
                    int col2 = int.Parse(inputTokens[4]);

                    if(matrix.Length < 0 || matrix.Length < row1 || matrix.Length < row2 || matrix[row1].Length < col1 ||
                        matrix[row2].Length < col2 || matrix[row1].Length < 0 || matrix[row2].Length < 0)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    
                    string first = matrix[row1][col1];
                    string second = matrix[row2][col2];

                    matrix[row1][col1] = second;
                    matrix[row2][col2] = first;

                    for (int i = 0; i < matrix.Length; i++)
                    {
                        Console.WriteLine(string.Join(" ", matrix[i]));
                        
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
             
            
            

        }
    }
}
