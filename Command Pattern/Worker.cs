using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class Worker
    {
        private ICommand command;

        public Worker(int nr)
        {
            Console.WriteLine("Worker "+nr+" gaat werken");
        }

        public void execute(ICommand cmmnd)
        {
            command = cmmnd;
            command.execute();
        }
    }
}
