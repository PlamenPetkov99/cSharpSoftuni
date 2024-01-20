namespace pascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedArray[i] = new long[i + 1];
            }

            jaggedArray[0][0] = 1;

            for (int row = 1; row < n; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {

                    if(col < jaggedArray[row - 1].Length)
                    {
                        jaggedArray[row][col] += jaggedArray[row - 1][col];
                    }
                    if (col - 1 >= 0)
                    {

                      jaggedArray[row][col] += jaggedArray[row - 1][col - 1];
                    }

                    
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }

        }
    }
}
