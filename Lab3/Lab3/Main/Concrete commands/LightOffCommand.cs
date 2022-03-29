using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Interface;
using Lab3.Main.Receiver;

namespace Lab3.Main.Concrete_commands
{
    internal class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public string Execute() => _light.Off();

        public string Undo() => _light.On();
    }
}
