using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class StreamReaderWriterClass
    {
        public void StreamWriterOperation()
        {
            Console.WriteLine("--------------Stream Writer------------");
            string filePath = @"D:\BridgeLabzz\FileIOOperations\WordFile1.txt";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("Hello I am writing this using Stream Writer Operation");
                sw.Close();
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }

        public void StreamReaderOperation()
        {
            Console.WriteLine("\n------------Stream Reader----------\n");
            string filePath = @"D:\BridgeLabzz\FileIOOperations\WordFile1.txt";
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
