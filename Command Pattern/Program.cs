using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class Program
    {
        private static Worker _worker;
        private static BackupManager _backupManager;

        static void Main(string[] args)
        {
            _backupManager = new BackupManager("Pietje", "sa35a5r3dg", "localhost", "demo 346");

            _worker = new Worker();
            _worker.addCommand(new CopyCommand(_backupManager));
            _worker.addCommand(new SendMailCommand(_backupManager));

            _worker.execute();
            _worker.execute();

            // Even wachten
            Console.ReadLine();
        }
    }
}
