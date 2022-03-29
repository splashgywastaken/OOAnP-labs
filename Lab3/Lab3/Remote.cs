using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Remote : Form
    {

        private bool _isOn = false;

        public Remote()
        {
            InitializeComponent();

            MainScreen.BackColor = Color.Gray;
            MainScreen.ForeColor = Color.LimeGreen;

        }

        private void DoorOpenButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
                AddText("Door opened");
        }

        private void DoorCloseButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
                AddText("Door closed");
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            if (!_isOn)
            {
                MainScreen.BackColor = Color.Black;
                _isOn = true;
            }
        }

        private void TurnOffButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
            {
                MainScreen.Text = string.Empty;
                MainScreen.BackColor = Color.Gray;
                _isOn = false;
            }
        }
        
        private void FanOnButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
                AddText("Fan turned on");
        }

        private void FanOffButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
                AddText("Fan turned off");
        }

        private void HeaterOnButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
                AddText("Heater turned on");
        }

        private void HeaterOffButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
                AddText("Heater turned off");
        }

        private void LightOnButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
                AddText("Light turned on");
        }
        
        private void LightOffButton_Click(object sender, EventArgs e)
        {
            if (_isOn)
                AddText("Light turned off");
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            MainScreen.Text = string.Empty;
        }

        public void AddText(string text)
        {
            MainScreen.AppendText(text);
            MainScreen.AppendText(Environment.NewLine);
        }

    }
}
