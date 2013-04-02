using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class Program
    {
        private static Worker _worker;
        private static BackupManager _backupManager, _backupManager2, _backupManager3;

        static void Main(string[] args)
        {
            _backupManager = new BackupManager("Pietje", "sa35a5r3dg", "localhost", "Backup 1 copy");
            _backupManager2 = new BackupManager("Klaas", "sa35a5r3dg", "localhost", "Backup 2 mail");
            _backupManager3 = new BackupManager("Klaas", "sa35a5r3dg", "localhost", "Backup 2 ftp");

            _worker = new Worker();
            _worker.addCommand(new CopyCommand(_backupManager));
            _worker.addCommand(new SendMailCommand(_backupManager2));
            _worker.addCommand(new SendByFTPCommand(_backupManager3));

            _worker.execute();
            _worker.execute();
            _worker.execute();
            //_worker.execute();

            // Even wachten
            Console.ReadLine();
        }
    }
}
