using System;
using System.IO;
using System.Security.Permissions;
using System.IO.Compression;

namespace DirectoriesAndFiles
{
    public class Assignment20
    {
        static string directoryName = @"C:\FileHandling\";
        static string fileRead = @"C:\FileHandling\FileRead.txt";
        static string fileWrite = @"C:\FileHandling\FileWrite.txt";
        public static void Main()
        {
            try
            {
                //create a new directory

                if (!Directory.Exists(directoryName))
                {
                    DirectoryInfo di = Directory.CreateDirectory(directoryName);
                    Console.WriteLine("Directory created successfully\n ");


                }
                else
                    Console.WriteLine("That path exists already\n");

                //creating two files in the directory

                if (!File.Exists(fileRead))
                {
                    using (FileStream fs = File.Create(fileRead))
                    {
                        Console.WriteLine("File created successfully \n");
                    }
                }
                else
                    Console.WriteLine("That file exists already\n");
                if (!File.Exists(fileWrite))
                {
                    using (FileStream fs = File.Create(fileWrite))
                    {
                        Console.WriteLine("File created successfully \n");
                    }
                }
                else
                    Console.WriteLine("That file exists already\n");
                DirectoryInfo dinfo = new DirectoryInfo(@"C:\");

                //displaying attributes of c drive

                if (dinfo.Exists)
                {
                    Console.WriteLine("\n..............");
                    Console.WriteLine("Subdirectories Present in {0} ;", dinfo);
                    DirectoryInfo[] diNames = dinfo.GetDirectories();
                    foreach (DirectoryInfo dir in diNames)
                        Console.WriteLine(dir.Name + "\n");
                    Console.WriteLine("\n..............");
                    Console.WriteLine("Files Present in {0} ;", dinfo);
                    FileInfo[] fNames = dinfo.GetFiles();
                    foreach (FileInfo files in fNames)
                        Console.WriteLine(files.Name + "\n");
                }
                else
                    Console.WriteLine("Path does not exists\n");

                //displaying attibutes of created directory and its files

                dinfo = new DirectoryInfo(directoryName);
                if (dinfo.Exists)
                {
                    Console.WriteLine("\n..............");
                    Console.WriteLine("Subdirectories Present in {0} ;", dinfo);
                    DirectoryInfo[] diNames = dinfo.GetDirectories();
                    foreach (DirectoryInfo dir in diNames)
                        Console.WriteLine(dir.Name + "\n");
                    Console.WriteLine("\n..............");
                    Console.WriteLine("Files Present in {0} ;", dinfo);
                    FileInfo[] fNames = dinfo.GetFiles();
                    foreach (FileInfo files in fNames)
                        Console.WriteLine("fIle Name : {0} File Length : {1} \n", files.Name, files.Length);
                }

                //displaying the full path of directory
                Console.WriteLine("\nThe full path of {0} is {1}\n", directoryName, Path.GetFullPath(directoryName));

                using (FileStream fWrite = new FileStream(fileRead, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    StreamWriter sw = new StreamWriter(fWrite);
                    sw.WriteLine("This is a simple text file");
                    sw.Flush();
                }


                //setting the control of FileRead to be Read Only
                FileIOPermission fileIOPerm = new FileIOPermission(FileIOPermissionAccess.Read, fileRead);

                //reading contents of FileRead and write it into FileWrite
                Console.WriteLine("Content in FileRead file :\n");
                using (FileStream fRead = new FileStream(fileRead, FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fRead);
                    Console.WriteLine(sr.ReadToEnd());
                }
                string content = File.ReadAllText(fileRead);
                File.WriteAllText(fileWrite, content);

                //Compress fileWrite using GZIP compression

                byte[] byteArray = new byte[fileWrite.Length];
                int indexBA = 0;
                foreach (char item in fileWrite.ToCharArray())
                {
                    byteArray[indexBA++] = (byte)item;
                }
                byte[] compress = Compress(byteArray);//function calling to compress the file
                File.WriteAllBytes(directoryName+"FileWriteZip.gz", compress);
            }

            catch (IOException e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
            Console.Read();

        }
        public static byte[] Compress(byte[] raw)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory, CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return memory.ToArray();
            }
        }
    }
}