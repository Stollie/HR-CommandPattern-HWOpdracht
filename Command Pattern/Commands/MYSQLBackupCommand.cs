using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class MYSQLBackupCommand : ICommand
    {
        private string _username, _password, _host, _databasename;

        public MYSQLBackupCommand(string username, string password, string host, string databasename)
        {
            _username       = username;
            _password       = password;
            _host           = host;
            _databasename   = databasename;
        }
        public void execute() 
        {
            Console.WriteLine("Backup van" + _databasename);
        }
        public void undo() { }
    }
}
