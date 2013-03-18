using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class Program
    {
        private static CommandQueue queue;
        private static Worker worker;

        static void Main(string[] args)
        {
            queue = new CommandQueue();
            queue.addCommand(new MYSQLBackupCommand("Pietje", "sa35a5r3dg", "localhost", "demo 346"));
            queue.addCommand(new MYSQLBackupCommand("Pietje", "sa35a5r3dg", "localhost", "demo 243"));


            worker = new Worker(1);

            worker.execute(queue.getCommand());

            // Even wachten
            Console.ReadLine();
        }
    }
}
