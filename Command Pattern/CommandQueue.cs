using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class CommandQueue
    {
        private Queue<ICommand> commands;

        public CommandQueue()
        {
            commands = new Queue<ICommand>();
        }

        public void addCommand(ICommand command)
        {
            commands.Enqueue(command);
        }

        public ICommand getCommand()
        {
            return commands.Dequeue();
        }
    }
}
