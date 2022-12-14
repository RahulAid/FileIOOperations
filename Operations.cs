using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class Operations
    {
        public void FileExists()
        {
            string filePath = @"D:\BridgeLabzz\FileIOOperations\WordFile1.txt";
            
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nFile Exists");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
            Console.ReadLine();
        }

        public void ReadAllLines()
        {
            Console.WriteLine("\n-------------Read All Lines------------\n");
            string filePath = @"D:\BridgeLabzz\FileIOOperations\WordFile1.txt";
            string[] lines;
            lines = File.ReadAllLines(filePath);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadLine();
        }

        public void ReadAllText()
        {
            Console.WriteLine("\n-------------Read All Text------------\n");
            string filePath = @"D:\BridgeLabzz\FileIOOperations\WordFile1.txt";
            string text;
            text = File.ReadAllText(filePath);
            Console.WriteLine(text);
            Console.ReadLine();
        }

        public void CopyPath()
        {
            Console.WriteLine("\n-----------Copy File Path------------");
            string filePath = @"D:\BridgeLabzz\FileIOOperations\WordFile1.txt";
            string copyFilePath = @"D:\BridgeLabzz\FileIOOperations\WordFile2.txt";
            File.Copy(filePath, copyFilePath);
            Console.WriteLine("\nCopied Successfully");
            string copiedText;
            copiedText = File.ReadAllText(copyFilePath);
            Console.WriteLine(copiedText);
        }

        public void DeletePath()
        {
            Console.WriteLine("\n-----------Delete File Path------------");
            string copyFilePath = @"D:\BridgeLabzz\FileIOOperations\WordFile2.txt";
            File.Delete(copyFilePath);
            Console.WriteLine("\nDeleted Successfully");
        }
        

    }
}
