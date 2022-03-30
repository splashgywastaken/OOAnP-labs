using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Lab3.Main.Concrete_commands;
using Lab3.Main.Interface;

namespace Lab3.Main
{
    internal class RemoteInvoker
    {
        private int UsedCommandsCount { get; set; }
        private int NumberOfCommands { get; set; }
        private ICommand[] OnCommands { get; }
        private ICommand[] OffCommands { get; }
        private Stack<ICommand> UndoCommand { get; set; }

        public RemoteInvoker(int numberOfCommands)
        {
            UsedCommandsCount = 0;
            NumberOfCommands = numberOfCommands;

            OnCommands = new ICommand[NumberOfCommands];
            OffCommands = new ICommand[NumberOfCommands];
            UndoCommand = new Stack<ICommand>();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public string OnButtonWasPressed(int slot)
        {
            UndoCommand.Push(OnCommands[slot]);
            UsedCommandsCount++;
            return OnCommands[slot].Execute();
        }

        public string OffButtonWasPressed(int slot)
        {
            UndoCommand.Push(OffCommands[slot]);
            UsedCommandsCount++;
            return OffCommands[slot].Execute();
        }

        public string UndoButtonWasPressed()
        {
            return UndoCommand.Count >= 1 ? UndoCommand.Pop().Undo() : "Command list is empty";
        }

        public override string ToString()
        {
            return
                string.Concat(
                    "Количество существующих комманд:\n", NumberOfCommands, "\n",
                    "Количество использованных комманд:\n", UsedCommandsCount, "\n",
                    "OnCommands\n", string.Join("\n", OnCommands.ToList()), "\n",
                    "OffCommands\n", string.Join("\n", OffCommands.ToList()), "\n",
                    "UndoCommands\n", string.Join("\n", UndoCommand)
                    );
        }
    }
}
