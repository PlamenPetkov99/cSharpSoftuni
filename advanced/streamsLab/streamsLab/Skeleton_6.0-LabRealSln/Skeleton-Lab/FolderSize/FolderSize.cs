namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            FileInfo[] infos = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
            StreamWriter sw = new StreamWriter(outputFilePath);
            double size = 0;
            foreach(var fi in infos)
            {
                size += fi.Length;
            }
            size = size / 1024 / 1024;
            using (sw)
            {
                sw.WriteLine(size);
            }

        }
    }
}
