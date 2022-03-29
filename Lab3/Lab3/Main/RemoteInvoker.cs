using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Interface;

namespace Lab3.Main
{
    internal class RemoteInvoker
    {
        private Stack<ICommand> _onCommands;
        private Stack<ICommand> _offCommands;

        public RemoteInvoker()
        {
            _onCommands = new Stack<ICommand>();
            _offCommands = new Stack<ICommand>();
        }

        private void SetCommand(ICommand command)
        {

            _onCommands.Push(command);

        }

        public string Execute(ICommand command)
        {

            

        }

    }
}
