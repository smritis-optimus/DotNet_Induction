using System;
using System.IO;

namespace Assignment22
{
    class BinaryFile
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            string bFileName = @"C:\FileHandling\BinaryFile.bin";
            BinaryReader br;
            int intWriteContent = 21;
            double doubleWriteContent = 2.0104;
            char charWriteContent = 's';
            string stringWriteContent = "this is a binary file";
            try
            {
                //creating a binary file  and writing content in it
                using (bw = new BinaryWriter(new FileStream(bFileName, FileMode.OpenOrCreate,FileAccess.Write)))
                {
                    bw.Write(intWriteContent);
                    bw.Write(doubleWriteContent);
                    bw.Write(charWriteContent);
                    bw.Write(stringWriteContent);
                }
                //reading the contents of binary file
                using (br = new BinaryReader(new FileStream(bFileName, FileMode.Open,FileAccess.Read)))
                {
                    int intReadContent = br.ReadInt32();
                    Console.WriteLine("Integer data: {0}\n", intReadContent);
                    double doubleReadContent = br.ReadDouble();
                    Console.WriteLine("Double data: {0}\n", doubleReadContent);
                    char charReadContent = br.ReadChar();
                    Console.WriteLine("Character data: {0}\n", charReadContent);
                    string stringReadContent = br.ReadString();
                    Console.WriteLine("String data: {0}\n", stringReadContent);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(" Error occured :", e.Message);
            }

            Console.Read();
        }
    }
}
