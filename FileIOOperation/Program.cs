using System.Timers;

namespace FileIOOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FileIO Operation Program");
            Console.WriteLine("Please select the given below program");
            Console.WriteLine("\n1:JsonDataSerilization\n2:JsonDataDeserialize");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    JsonDataOperations.JsonDataSerialize();
                    break;
                case 2:
                    JsonDataOperations.JsonDataDeserialize();
                    break;
            }
        }
    }
}
