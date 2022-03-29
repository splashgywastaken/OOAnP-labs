using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Entities;
using Lab3.Main.Interface;

namespace Lab3.Main.Concrete_commands
{
    internal class DoorCloseCommand : ICommand
    {
        private readonly Door _door;

        public DoorCloseCommand(Door door)
        {
            _door = door;
        }

        public string Execute() => _door.Close();

        public string Undo() => _door.Open();
    }
}
