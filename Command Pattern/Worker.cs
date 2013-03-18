using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class Worker
    {
        private ICommand command;

        void Worker(ICommand cmmnd)
        {
            command = cmmnd;
        }

        public void execute()
        {
            command.execute();
        }
    }
}
