using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;

namespace WebApplication1.Models
{
    public class FileManager
    {
        public static List<Phone> phonesList;

        private static readonly string _filePath = HostingEnvironment.MapPath("/Files/phones.json");

        public static void SerializePhone(List<Phone> phonesList)
        {
            string json = JsonConvert.SerializeObject(phonesList);

            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                streamWriter.WriteLine(json);
            }
        }
        public static List<Phone> DeserializePhones()
        {
            using (StreamReader fs = new StreamReader(_filePath))
            {
                JsonTextReader jsonTextReader = new JsonTextReader(fs);
                JsonSerializer jsonSerializer = new JsonSerializer();
                var listCheck = jsonSerializer.Deserialize<List<Phone>>(jsonTextReader);
                if (listCheck != null)
                {
                    phonesList = listCheck;
                    phonesList.OrderBy(i => i.Name);
                }
                return phonesList;
            }
        }
    }
}