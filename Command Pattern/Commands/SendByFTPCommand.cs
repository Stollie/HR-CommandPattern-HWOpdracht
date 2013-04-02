using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class SendByFTPCommand : ICommand
    {
        private BackupManager _manager;

        public SendByFTPCommand(BackupManager manager)
        {
            _manager = manager;
        }
        public void execute()
        {
            _manager.backup();
            _manager.copyToDisk();
        }
    }
}
