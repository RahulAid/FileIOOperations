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

    }
}
