using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace File_management_system
{
    class SerializerJson<T>
    {
        private Stream _stream;
        public string Path { get; }
        public SerializerJson()
        {
            var mainFloder = new Folders();
            Path = System.IO.Path.Combine(mainFloder.directoryInfo.FullName, "log.json");
            if (!File.Exists(Path)) File.Create(Path).Close();
        }
        public void Serialize(T txt)
        {
            var json = JsonConvert.SerializeObject(txt);
            json = Newtonsoft.Json.Linq.JObject.Parse(json).ToString();

            using (_stream = File.Open(Path, FileMode.OpenOrCreate, 
            FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(_stream, 
                    System.Text.Encoding.Default))
                    writer.Write(json);
            }
        }
        public T Deserialize()
        {
            string content = "";
            using (_stream = File.Open(Path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(_stream, System.Text.Encoding.Default))
                    content = reader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}

