namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader sr = new StreamReader(inputFilePath);
            string currentLine = string.Empty;
            string result = string.Empty;
            using (sr)
            {
                int counter = 0;
                while((currentLine = sr.ReadLine())!= null)
                {
                    if(counter % 2 == 0)
                    {
                        currentLine = currentLine.Replace('-', '@');//'-' | ', '  | '. '|  '! '|  '? '
                        currentLine = currentLine.Replace(',', '@');//'-' | ', '  | '. '|  '! '|  '? '
                        currentLine = currentLine.Replace('.', '@');//'-' | ', '  | '. '|  '! '|  '? '
                        currentLine = currentLine.Replace('!', '@');//'-' | ', '  | '. '|  '! '|  '? '
                        currentLine = currentLine.Replace('?', '@');//'-' | ', '  | '. '|  '! '|  '? '
                        string[] resultAr = currentLine.Split().Reverse().ToArray();
                        foreach (string ra in resultAr)
                        {
                            result += ra + " ";
                        }
                        result += "\n";
                        
                    }
                    
                    counter++;
                }
            }
            return result;
        }
    }
}
