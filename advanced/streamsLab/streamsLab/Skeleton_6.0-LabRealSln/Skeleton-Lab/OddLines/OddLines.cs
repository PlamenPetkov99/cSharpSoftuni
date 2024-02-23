namespace OddLines
{
    using System;
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            using (reader)
            {
                using (writer)
                {
                    string line = string.Empty;
                    int counter = 0;
                    while ((line = reader.ReadLine())!= null)
                    {
                        if(counter%2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                    }

                }

            }

        }
    }
}
