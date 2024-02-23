namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.WebSockets;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            var fsw = new FileStream(outputPath, FileMode.Create);
            byte[] bytes = File.ReadAllBytes(binaryFilePath);
            byte[] bytesTxt = File.ReadAllLines(bytesFilePath).Select(byte.Parse).ToArray();
            Dictionary<byte, int> ocur = new Dictionary<byte, int>();
            foreach(byte b in bytesTxt)
            {
                ocur[b] = 0;
            }

            foreach (var item in collection)
            {

            }
            


        }
    }
}
