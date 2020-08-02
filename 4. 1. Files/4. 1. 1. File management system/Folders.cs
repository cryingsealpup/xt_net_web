using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace File_management_system
{
    class Folders
    {
        private string _folderName = "backup";
        private string _pathBackup = AppDomain.CurrentDomain.BaseDirectory;
        public DirectoryInfo directoryInfo;
        public Folders()
        {
            directoryInfo = new System.IO.DirectoryInfo(System.IO.Path.Combine(_pathBackup, _folderName));
            try
            {
                if (!directoryInfo.Exists) 
                    System.IO.Directory.CreateDirectory(directoryInfo.FullName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<FileProcessor> TxtFiles
        {
            get
            {
                var fileInfoList = GetFiles();
                return GetBackups(fileInfoList);
            }
        }

        private List<System.IO.FileInfo> GetFiles()
        {
            var files = new List<System.IO.FileInfo>();
            try
            {
                files = (directoryInfo.EnumerateFiles($"*.txt")).ToList();
                var directories = directoryInfo.EnumerateDirectories("*", System.IO.SearchOption.AllDirectories);
                foreach (var dir in directories)
                    files.AddRange(dir.EnumerateFiles($"*.txt"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return files;
        }
        private List<FileProcessor> GetBackups(List<System.IO.FileInfo> fileInfos)
        {
            var fileList = new List<FileProcessor>();
            try
            {
                foreach (var fileInfo in fileInfos)
                {
                    var FileProcessor = new FileProcessor(fileInfo);
                    fileList.Add(FileProcessor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fileList;
        }
    }
}
