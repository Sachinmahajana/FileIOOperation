using System.Timers;

namespace FileIOOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FileIO Operation Program");
            string OutputFile = "D:\\CsharpBasicprograms\\FileIOOperation\\FileIOOperation\\FileIO\\Outputfile.txt";
            string path = "D:\\CsharpBasicprograms\\FileIOOperation\\FileIOOperation\\FileIO\\Sample.txt";
            IsFileExist(path);
            ReadAllLinesOnebyOne(path);
            ReadAlllinesAtonce(path);
            CopyFIle(path, OutputFile);
            DeleteFile(OutputFile);
        }
        public static bool IsFileExist(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File is Exists");
                return true;
            }
            else
            {
                Console.WriteLine("File is not Exists");
                return false;
            }
        }
        public static void ReadAllLinesOnebyOne(string path)
        {
            if (IsFileExist(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
        public static void ReadAlllinesAtonce(string path)
        {
            if (IsFileExist(path))
            {
                string lines = File.ReadAllText(path);
                Console.WriteLine(lines);
            }
        }
        public static void CopyFIle(string path, string destin)
        {
            if (IsFileExist(path))
            {
                File.Copy(path, destin);
                if (File.Exists(destin))
                {
                    Console.WriteLine("New file is created");
                }
                else
                {
                    Console.WriteLine("New file not created");
                }
            }
        }
        public static void DeleteFile(string destin)
        {
            if (IsFileExist(destin))
            {
                File.Delete(destin);
                if (File.Exists(destin))
                {
                    Console.WriteLine("New File is not deleted");
                }
                else
                {
                    Console.WriteLine("New file is deleted");
                }
            }
        }


    }
}
