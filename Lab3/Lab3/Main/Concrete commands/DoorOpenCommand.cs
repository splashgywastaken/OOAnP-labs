using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Entities;
using Lab3.Main.Interface;

namespace Lab3.Main.Concrete_commands
{
    internal class DoorOpenCommand : ICommand
    {
        private readonly Door _door;

        public DoorOpenCommand(Door door)
        {
            _door = door;
        }

        public string Execute() => _door.Open();

        public string Undo() => _door.Close();
    }
}
