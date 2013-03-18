using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class MSSQLBackupCommand : ICommand
    {

        public MSSQLBackupCommand(string username, string password, string host, string databasename)
        {

        }
        public void execute() { }
        public void undo() { }
    }
}
