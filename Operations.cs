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

    }
}
