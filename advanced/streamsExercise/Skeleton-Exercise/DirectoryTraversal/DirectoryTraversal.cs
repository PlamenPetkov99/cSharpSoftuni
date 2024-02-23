namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = @"C:\Users\User\Downloads";//Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);
            ;
            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string result = string.Empty;
            Dictionary<string, Dictionary<string, double>> extensionFileNameFileLenght = new Dictionary<string, Dictionary<string, double>>();
            string[] files = Directory.GetFiles(inputFolderPath);
            foreach (string file in files)
            {
                FileInfo currentFileInfo = new FileInfo(file);
                string extension = currentFileInfo.Extension;
                string fileName = currentFileInfo.Name;
                double sizeKB = (double)(currentFileInfo.Length) / 1000.0; // NOT SURE IF I SHOULD DIVIDE IT BY 1000

                if (!extensionFileNameFileLenght.ContainsKey(extension))
                {
                    extensionFileNameFileLenght[extension] = new Dictionary<string, double>();
                    extensionFileNameFileLenght[extension][fileName] = sizeKB;
                }
                else
                {
                    extensionFileNameFileLenght[extension][fileName] = sizeKB;
                }

            }

            extensionFileNameFileLenght = extensionFileNameFileLenght.OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);
       //     extensionFileNameFileLenght = extensionFileNameFileLenght.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in extensionFileNameFileLenght)
            {
                result += $"{kvp.Key}\n";
                foreach (var nameSize in kvp.Value)
                {
                    result += $"--{nameSize.Key} - {nameSize.Value}kb\n";
                }

            }

            return result;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            throw new NotImplementedException();
        }
    }
}
