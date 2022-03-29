using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Entities;
using Lab3.Main.Interface;

namespace Lab3.Main.Concrete_commands
{
    internal class HeaterOnCommand : ICommand
    {
        private readonly Heater _heater;

        public HeaterOnCommand(Heater heater)
        {
            _heater = heater;
        }

        public string Execute() => _heater.On();

        public string Undo() => _heater.Off();
    }
}
