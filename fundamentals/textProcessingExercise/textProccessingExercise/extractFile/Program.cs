using System.Threading.Channels;

namespace extractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fullPath = Console.ReadLine().Split("\\" , StringSplitOptions.RemoveEmptyEntries).ToArray();
            //C:\Internal\training-internal\Template.pptx

            string fileNameAndExtenstion = fullPath[fullPath.Length-1]; //Template.pptx
            
            int dotIndex = fileNameAndExtenstion.IndexOf(".");

            string fileName = fileNameAndExtenstion.Substring(0,dotIndex);
            string extension = fileNameAndExtenstion.Substring(dotIndex+1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
