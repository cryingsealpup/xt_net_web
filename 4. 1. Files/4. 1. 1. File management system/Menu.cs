using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_management_system
{
    class Menu
    {
        public void Run()
        {
            var mainFloder = new Folders();
            do
            {
                Console.WriteLine("Select the mode: ");
                Console.WriteLine("\t1. Observer");
                Console.WriteLine("\t2. Recovery");
                int input = 0;
                while (!int.TryParse(Console.ReadLine(), out input) && (input < 1 || input > 2))
                {
                    Console.WriteLine("{0} Incorrect input. Try again. {0}", Environment.NewLine);
                }
                switch (input)
                {
                    case 1:
                        var watcher = new Observer();
                        watcher.Run(mainFloder.directoryInfo.FullName);
                        break;

                    case 2:
                        var backupControls = new Recovery();
                        backupControls.RestoreFile();
                        break;

                    default:
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

        }
    }
}
