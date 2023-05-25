using System.Net.Http.Headers;
using System.Timers;

namespace FileIOOperation
{
    internal class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FileIO Operation Program");
            Console.WriteLine("Please Choose given program");
            Console.WriteLine("\n1:Binary Serialization\n2:BinaryDeserialize");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinaryDataOperation.BinarySerialize();   
                    break;
                case 2:
                    BinaryDataOperation.BinaryDeserialize();
                    break;
                default:
                    Console.WriteLine("Please select program given below");
                    break;
            } 
        }
    }
}
