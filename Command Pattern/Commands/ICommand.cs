using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    public interface ICommand
    {
        public void execute();
        public void undo();
    }
}
