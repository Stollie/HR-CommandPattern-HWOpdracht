using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class MYSQLBackupCommand : ICommand
    {
        void MYSQLBackupCommand(string username, string password, string host, string databasename)
        {

        }
        public void execute() { }
        public void undo() { }
    }
}
