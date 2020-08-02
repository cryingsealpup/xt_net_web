using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_management_system
{
    class BackupLogs
    {
        public Dictionary<DateTime, List<FileProcessor>> BackupsLogDictionary { get; set; }
        public Dictionary<DateTime, List<FileProcessor>> GetDictionaryFromJson()
        {
            var jsonAdapter = new SerializerJson<BackupLogs>();
            var mainFloder = new Folders();
            var BackupLogs = jsonAdapter.Deserialize() ?? new BackupLogs();
            return BackupLogs.BackupsLogDictionary;
        }

        public void AddChanges(DateTime date, List<FileProcessor> files)
        {
            if (BackupsLogDictionary == null) BackupsLogDictionary = new Dictionary<DateTime, List<FileProcessor>>();
            BackupsLogDictionary.Add(date, files);
        }

    }
}
