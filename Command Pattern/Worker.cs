using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class Worker
    {
        private Queue<ICommand> _commands;

        public Worker()
        {
            _commands = new Queue<ICommand>();
        }

        public void addCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }


        public void execute()
        {
            // Haal het laaste item uit de queue
            ICommand command = _commands.Dequeue();
            command.execute();
        }
    }
}
