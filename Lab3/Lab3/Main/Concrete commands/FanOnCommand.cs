using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Entities;
using Lab3.Main.Interface;

namespace Lab3.Main.Concrete_commands
{
    internal class FanOnCommand : ICommand
    {

        private readonly Fan _fan;

        public FanOnCommand(Fan fan)
        {
            _fan = fan;
        }

        public string Execute() => _fan.On();

        public string Undo() => _fan.Off();
    }
}
