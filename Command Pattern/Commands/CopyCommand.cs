﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class CopyCommand : ICommand
    {
        private BackupManager _manager;

        public CopyCommand(BackupManager manager)
        {
            _manager = manager;
        }
        public void execute()
        {
            _manager.backup();
            _manager.copyToDisk();
        }
        //public void undo() { }
    }
}
