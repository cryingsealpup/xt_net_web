using System;
using System.IO;
using System.Text;

namespace File_management_system
{
    class FileProcessor
    {
        public string Name { get; set; }
        public string DirectoryName { get; set; }
        public string FullName { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime LastWriteTime { get; set; }
        public FileProcessor(FileInfo file)
        {
            Name = file.Name;
            FullName = file.FullName;
            DirectoryName = file.DirectoryName;
            CreationTime = file.CreationTime;
            LastAccessTime = file.LastAccessTime;
            LastWriteTime = file.LastWriteTime;
            Content = Read(file);
        }

        public void Create()
        {
            var fileInfo = new FileInfo(FullName) { 
                CreationTime = CreationTime, 
                LastAccessTime = LastAccessTime, 
                LastWriteTime = LastWriteTime };
            fileInfo.Create().Close();
            using (var stream = File.Open(fileInfo.FullName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (var writer = new StreamWriter(stream, System.Text.Encoding.Default))
                    writer.Write(Content);
            }
        }

        private string Read(FileInfo file)
        {
            var content = "";
            using (var stream = File.Open(file.FullName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new StreamReader(stream, Encoding.Default))
                content = reader.ReadToEnd();
            }
            return content;
        }
    }
}

