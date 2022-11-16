using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;

namespace PhoneBookLibJson
{
    class FileManager
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
            if (!File.Exists(_filePath))
            {
                using (StreamWriter streamWriter = new StreamWriter(_filePath))
                {
                    streamWriter.Write("");
                }
            }
            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                string fileData = streamReader.ReadToEnd();
                if (!string.IsNullOrEmpty(fileData))
                    phonesList = System.Text.Json.JsonSerializer.Deserialize<List<Phone>>(fileData);
                else
                    phonesList = new List<Phone>();
            }
            return phonesList;

        }
    }
}