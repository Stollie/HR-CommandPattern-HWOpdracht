using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class FullBackupCommand : ICommand
    {
        private List<ICommand> commands;

        void FullBackupCommand(List<ICommand> cmmnds)
        {
            commands = cmmnds;
        }

        public void execute()
        {
            foreach (ICommand command in commands)
            {
                command.execute();
            }
        }
    }
}
