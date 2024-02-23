
namespace demoONHardestLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirDemoPath = @"E:\C# repository github\cSharpSoftuni\advanced\streamsLab\streamsLab\Skeleton_6.0-LabRealSln\Skeleton-Lab\demoONHardestLab";

            long sizeOutput = getSizeFiles(dirDemoPath);
            Console.WriteLine(sizeOutput/1024);
        }

        private static long getSizeFiles(string currentDir)
        {
            long curSize = 0;
            string[] allFilesCurrentDir = Directory.GetFiles(currentDir);
            foreach (var file in allFilesCurrentDir)
            {
                FileInfo currentFile = new FileInfo(file);
                curSize += currentFile.Length;
            }

            string[] allDirsInDir = Directory.GetDirectories(currentDir);
            foreach (string dir in allDirsInDir) 
            {
               
               curSize += getSizeFiles(dir);

            }
            return curSize;

        }
    }
}
