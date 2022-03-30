using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab3.Main;
using Lab3.Main.Concrete_commands;
using Lab3.Main.Entities;
using Lab3.Main.Receiver;

namespace Lab3
{
    public partial class Remote : Form
    {
        private RemoteInvoker RemoteInvoker { get; set; }

        private Door Door { get; set; }
        private Light Light { get; set; }
        private Fan Fan { get; set; }
        private Heater Heater { get; set; }

        private bool _isOn;

        public Remote()
        {
            InitializeComponent();

            MainScreen.BackColor = Color.Gray;
            MainScreen.ForeColor = Color.LimeGreen;
        }

        private void Initialize()
        {
            const int numberOfCommands = 4;
            new Stack<Func<string>>();
            RemoteInvoker = new RemoteInvoker(numberOfCommands);

            Door = new Door();
            Light = new Light();
            Fan = new Fan();
            Heater = new Heater();

            RemoteInvoker.SetCommand(0, new HeaterOnCommand(Heater), new HeaterOffCommand(Heater));
            RemoteInvoker.SetCommand(1, new LightOnCommand(Light), new LightOffCommand(Light));
            RemoteInvoker.SetCommand(2, new FanOnCommand(Fan), new FanOffCommand(Fan));
            RemoteInvoker.SetCommand(3, new DoorOpenCommand(Door), new DoorCloseCommand(Door));

        }

        private void Deinitialize()
        {
            RemoteInvoker = null;

            Door = null;
            Light = null;
            Fan = null;
            Heater = null;
        }

        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            if (_isOn) return;

            Initialize();
            MainScreen.BackColor = Color.Black;
            _isOn = true;
        }

        private void TurnOffButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;

            Deinitialize();
            MainScreen.Text = string.Empty;
            MainScreen.BackColor = Color.Gray;
            _isOn = false;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;

            AddText(RemoteInvoker.UndoButtonWasPressed());
        }

        private void DoorOpenButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;

            AddText(RemoteInvoker.OnButtonWasPressed(3));
        }

        private void DoorCloseButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;
            
            AddText(RemoteInvoker.OffButtonWasPressed(3));
        }

        private void LightOnButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;

            AddText(RemoteInvoker.OnButtonWasPressed(2));
        }

        private void LightOffButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;

            AddText(RemoteInvoker.OffButtonWasPressed(2));
        }

        private void HeaterOnButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;
            
            AddText(RemoteInvoker.OnButtonWasPressed(1));
        }

        private void HeaterOffButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;
            
            AddText(RemoteInvoker.OffButtonWasPressed(1));
        }

        private void FanOnButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;

            AddText(RemoteInvoker.OnButtonWasPressed(0));
        }

        private void FanOffButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;

            AddText(RemoteInvoker.OffButtonWasPressed(0));
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            MainScreen.Text = string.Empty;
        }

        private void AddText(string text)
        {

            if (text == string.Empty)
                text = "Command was already used";

            MainScreen.AppendText(text);
            MainScreen.AppendText(Environment.NewLine);
        }

        private void useCommandsButton_Click(object sender, EventArgs e)
        {
            if (!_isOn) return;

            Console.WriteLine(RemoteInvoker.ToString());
        }
    }
}
