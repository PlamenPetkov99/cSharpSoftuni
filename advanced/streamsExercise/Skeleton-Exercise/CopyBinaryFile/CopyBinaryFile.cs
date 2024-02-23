namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            FileStream fs = new FileStream(inputFilePath, FileMode.Open);
            FileStream fileStream = new FileStream(outputFilePath, FileMode.Create);
            byte[] bytes = new byte[fs.Length];
            
            fs.Read(bytes, 0, bytes.Length);

            fileStream.Write(bytes);
            
            
        }
    }
}
