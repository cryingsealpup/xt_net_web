using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_management_system
{
    class Recovery
    {
        private Dictionary<DateTime, List<FileProcessor>> _dictionary;
        private Folders _backupfolder;

        public Recovery()
        {
            GetBackups();
            _backupfolder = new Folders();
        }

        public void RestoreFile()
        {
            PrintBackups();
            var backupFiles = GetFileByDate();
            if (backupFiles != null)
            {
                DeleteCurrent(_backupfolder.TxtFiles);
                Restore(backupFiles);
                Console.WriteLine("Recovered!{0}", Environment.NewLine);
            }
        }

        private void Restore(List<FileProcessor> backupFiles)
        {
            foreach (var file in backupFiles)
            {
                if (file.DirectoryName == _backupfolder.directoryInfo.FullName) file.Create();
                else
                {
                    var relativePath = file.DirectoryName.Substring(_backupfolder.directoryInfo.FullName.Length + 1);
                    var folderNames = relativePath.Split(Path.DirectorySeparatorChar);
                    var currentPath = _backupfolder.directoryInfo.FullName;

                    foreach (var name in folderNames)
                    {
                        currentPath = Path.Combine(currentPath, name);
                        try
                        {
                            if (!Directory.Exists(currentPath))
                            {
                                Directory.CreateDirectory(currentPath);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    file.Create();
                }
            }

        }
        private void DeleteCurrent(List<FileProcessor> files)
        {
            try
            {
                foreach (var file in files)
                {
                    File.SetAttributes(file.FullName, FileAttributes.Normal);
                    File.Delete(file.FullName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private List<FileProcessor> GetFileByDate()
        {
            int input = 0;

            while (!int.TryParse(Console.ReadLine(), out input)
                    && (input <= 0 || input > _dictionary.Count))
            {
                Console.WriteLine("\nIncorrect input. Try again.\n");
            }

            return _dictionary.Values.ElementAt(input);
        }

        private void PrintBackups()
        {
            if (_dictionary == null)
                Console.WriteLine("{0}Empty", Environment.NewLine);
            else
            {
                Console.WriteLine("{0}Choose backup by date {0}", Environment.NewLine);
                int index = 1;
                foreach (DateTime date in _dictionary.Keys)
                {
                    Console.WriteLine(" {0}: {1:F}", index, date);
                    index++;
                }
            }
        }
        private void GetBackups()
        {
            var BackupLogs = new BackupLogs();
            _dictionary = new Dictionary<DateTime, List<FileProcessor>>();

            try
            {
                _dictionary = BackupLogs.GetDictionaryFromJson();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
    }
}
