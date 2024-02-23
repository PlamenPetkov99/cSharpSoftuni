namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<string> firstInput = new List<string>();
            List<string> secondInput = new List<string>();

            using(var reader = new StreamReader(firstInputFilePath))
            {
                string line = string.Empty;
                while((line = reader.ReadLine())!= null) 
                {
                firstInput.Add(line);
                }
            }
            using (var reader = new StreamReader(secondInputFilePath))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                secondInput.Add(line);
                }
            }

            using(var writer = new StreamWriter(outputFilePath))
            {
                while(firstInput.Count > 0 && secondInput.Count > 0)
                {
                    writer.WriteLine(firstInput[0]);
                    writer.WriteLine(secondInput[0]);
                    firstInput.RemoveAt(0);
                    secondInput.RemoveAt(0);
                }

                if(firstInput.Count > 0)
                {
                    foreach (string word in firstInput)
                    {
                        writer.WriteLine(word);
                    }
                }
                else if(secondInput.Count > 0)
                {
                    foreach (string word in secondInput)
                    {
                        writer.WriteLine(word);
                    }
                }
            }

        }
    }
}
