using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Interface;

namespace Lab3.Main.Concrete_commands
{
    internal class NoCommand : ICommand
    {
        public string Execute()
        {
            throw new NotImplementedException();
        }

        public string Undo()
        {
            throw new NotImplementedException();
        }
    }
}
