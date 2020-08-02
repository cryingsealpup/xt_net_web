using System;
using System.IO;

namespace File_management_system
{
    class Observer
    {
        private BackupLogs _backupLogs;
        private FileSystemWatcher _fileSystemWatcher;

        public Observer()
        {
            _backupLogs = new BackupLogs();
            _backupLogs.BackupsLogDictionary = _backupLogs.GetDictionaryFromJson();

        }

        public void Run(string path)
        {
            using (_fileSystemWatcher = new FileSystemWatcher(path, "*.txt"))
            {
                _fileSystemWatcher.IncludeSubdirectories = true;

                _fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName | NotifyFilters.CreationTime
                                     | NotifyFilters.Attributes;

                _fileSystemWatcher.Changed += OnChanged;
                _fileSystemWatcher.Created += OnChanged;
                _fileSystemWatcher.Deleted += OnChanged;
                _fileSystemWatcher.Renamed += OnRenamed;

                _fileSystemWatcher.EnableRaisingEvents = true;

                Console.WriteLine("{0} Press Enter to exit {0}", Environment.NewLine);
                string entered = "";
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                    entered = Console.ReadLine();
            }
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            try
            {
                _fileSystemWatcher.EnableRaisingEvents = false;
                CommitChanges();
                Console.WriteLine("File renamed" + Environment.NewLine);
            }
            finally
            {
                _fileSystemWatcher.EnableRaisingEvents = true;
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            try
            {
                _fileSystemWatcher.EnableRaisingEvents = false;
                CommitChanges();
                Console.WriteLine("File changed" + Environment.NewLine);
            }
            finally
            {
                _fileSystemWatcher.EnableRaisingEvents = true;
            }
        }

        private void CommitChanges()
        {
            var backupFolder = new Folders();
            var bacupsList = backupFolder.TxtFiles;
            _backupLogs.AddChanges(DateTime.Now, bacupsList);
            var jsonAdapter = new SerializerJson<BackupLogs>();
            jsonAdapter.Serialize(_backupLogs);
        }
    }
}

