using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    internal class JsonDataOperations
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
    }
}
