using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class BackupManager
    {
        private string _username, _password, _host, _databasename;

        public BackupManager(string username, string password, string host, string databasename)
        {
            _username       = username;
            _password       = password;
            _host           = host;
            _databasename   = databasename;
        }

        public void backup() 
        {
            Console.WriteLine("Backup van" + _databasename);
        }

        public void sendBySFTP()
        {
            Console.WriteLine("Backup " + _databasename + " via SFTP versturen");
        }

        public void sendMail()
        {
            Console.WriteLine("Send " + _databasename + " link by mail");
        }

        public void copyToDisk()
        {
            Console.WriteLine("Copy " + _databasename + " backup to second HD");
        }
    }
}
