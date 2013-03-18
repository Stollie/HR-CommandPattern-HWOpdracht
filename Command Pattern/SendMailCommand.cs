using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public class SendMailCommand : ICommand
    {
        public void execute() { }
        public void undo() { }
    }
}
