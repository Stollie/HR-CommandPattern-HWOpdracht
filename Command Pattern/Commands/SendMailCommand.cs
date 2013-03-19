using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class SendMailCommand : ICommand
    {
        private BackupManager _manager;

        public SendMailCommand(BackupManager manager)
        {
            _manager = manager;
        }
        public void execute()
        {
            _manager.backup();
            _manager.sendMail();
        }
        //public void undo() { }
    }
}