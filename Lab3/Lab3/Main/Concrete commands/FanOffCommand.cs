using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Entities;
using Lab3.Main.Interface;

namespace Lab3.Main.Concrete_commands
{
    internal class FanOffCommand : ICommand
    {
        private readonly Fan _fan;

        public FanOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public string Execute() => _fan.Off();

        public string Undo() => _fan.On();
    }
}
