using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "D:\\ubaytest\\CSH\\";
            //string path = "Fake\\";

           //string fileName = "AAA.txt";

            //string content = System.IO.File.ReadAllText(path + fileName);
            //string content = "Hello World!";
            //TestFileReader.WriteFile(path + fileName, content);

            //Console.WriteLine(content);
            Console.ReadLine();

            string newPath = "D:\\ubaytest\\CSH\\";
            Console.WriteLine(System.IO.Path.Combine("D:\\ubaytest\\CSH\\", "AAA.txt"));

            Console.WriteLine(System.IO.Path.GetDirectoryName(newPath));

            Console.WriteLine(System.IO.Path.GetFileName(newPath));
            
        }
    }
}
