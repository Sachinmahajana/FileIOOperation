using System.Timers;

namespace FileIOOperation
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FileIO Operation Program");
            Console.WriteLine("Please select the given below program");
            Console.WriteLine("\n1:JsonDataSerilization\n2:JsonDataDeserialize\n3:XMLDataserialize\n4:XMLDeserilization");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Serialization.JsonDataSerialize();
                    break;
                case 2:
                    Serialization.JsonDataDeserialize();
                    break;
                case 3:
                    Serialization.XMLSerializationFn();
                    break;
                case 4:
                    Serialization.XMLDeserialization();
                    break;
                   
            }
        }
    }
}
