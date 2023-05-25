using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIOOperation
{
    public class Serialization
    {
        //Json DataSerialization 
        public static void JsonDataSerialize()
        {
            string jsonpath = "D:\\CsharpBasicprograms\\FileIOOperation\\FileIOOperation\\FileIO\\JsonData.JSON";

            try
            {
                List<Contact> contact = new List<Contact>()
                {
                  new Contact() {Name = "Ajay",Id = 295,Age = 23},
                  new Contact() {Name = "Surend",Id=293,Age = 24},
                  new Contact() {Name = "Sandip",Id = 287,Age= 22}

                };
                string data = JsonConvert.SerializeObject(contact);
                File.WriteAllText(jsonpath, data);
                Console.WriteLine("Json Serialization Completed Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
        //Json DataDeserialization
        public static void JsonDataDeserialize()
        {
            string jsonpath = "D:\\CsharpBasicprograms\\FileIOOperation\\FileIOOperation\\FileIO\\JsonData.JSON";
            try
            {
                string jsondata = File.ReadAllText(jsonpath);
                List<Contact> list = JsonConvert.DeserializeObject<List<Contact>>(jsondata);

                foreach (Contact contacts in list)
                {
                    Console.WriteLine(contacts);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void XMLSerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\XMLData.XML";
            try
            {
                List<Contact> contact = new List<Contact>()
                {
                    new Contact() {Id = 363, Name="Manish", Age= 26},
                    new Contact() {Id = 364, Name="Dheeraj", Age= 24},
                    new Contact() {Id = 365, Name="Ramesh", Age= 28},
                };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contact>));
                StreamWriter sw = new StreamWriter(path);
                xmlSerializer.Serialize(sw, contact);
                Console.WriteLine("XML Serialization Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void XMLDeserialization()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\XMLData.XML";

            try
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Contact>));
                FileStream stream = new FileStream(path, FileMode.Open);
                List<Contact> name = (List<Contact>)xmlserializer.Deserialize(stream);

                foreach (Contact data in name)
                {
                    Console.WriteLine(data);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
    }
}
