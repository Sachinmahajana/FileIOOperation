using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileIOOperation
{
    internal class BinaryDataOperation
    {
        public static string binarypath = "D:\\CsharpBasicprograms\\FileIOOperation\\FileIOOperation\\FileIO\\binarydata.txt";
        //Binary Serialization
        public static void BinarySerialize()
        {
            List<Contacts> contact = new List<Contacts>();
            {
                new Contacts() { firstName = "Ajay", lastName = "Shrivastav", Phone = 9845637487 };
                new Contacts() { firstName = "Sachin", lastName = "Mahajan", Phone = 9370844315 };
            };
            BinaryFormatter binary = new BinaryFormatter();
            FileStream stream = new FileStream(binarypath, FileMode.OpenOrCreate);
            binary.Serialize(stream, contact);
            stream.Close();
            Console.WriteLine("Binary Serialization Completed Sucessfully");
        }
        //Binary Deserialization
        public static void BinaryDeserialize()
        {
            try
            {
                FileStream stream = new FileStream(binarypath, FileMode.Open);
                BinaryFormatter binary = new BinaryFormatter();
                List<Contacts> listofContacts = (List<Contacts>) binary.Deserialize(stream);
                stream.Close();
                foreach (Contacts list in listofContacts)
                {
                    Console.WriteLine(list);
                }
                Console.WriteLine("Binary Deserialization Completed sucessfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class Contacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long Phone { get; set; }

        public override string ToString()
        {
            return $"firstName: {firstName} lastName: {lastName} Phone: {Phone}";
        }

    }
}