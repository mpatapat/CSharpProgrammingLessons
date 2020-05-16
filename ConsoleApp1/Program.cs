using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo currentDir = new DirectoryInfo(".");

            DirectoryInfo personalDir = new DirectoryInfo(@"C:\Users\mmpatapat");
            Console.WriteLine(personalDir.FullName);
            Console.WriteLine(personalDir.Name);
            Console.WriteLine(personalDir.Parent);
            Console.WriteLine(personalDir.Attributes);
            Console.WriteLine(personalDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\mmpatapat\CSharpData");

            
            string[] customers = { ",Bob Smith", "Sally Smith", "Rober Smith" };

            string pathFileName = @"C:\Users\mmpatapat\CSharpData\FileName1.txt";
            File.WriteAllLines(pathFileName,customers);

            foreach (string cust in File.ReadAllLines(pathFileName))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            
            FileInfo[] txtFiles = dataDir.GetFiles("*.txt",SearchOption.AllDirectories);

            Console.WriteLine("Matches : {0}",txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }



            Console.WriteLine("File System / File Manipulations");
            Console.ReadLine();
        }
    }
}
