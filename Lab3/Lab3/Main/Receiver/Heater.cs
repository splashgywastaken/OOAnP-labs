using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Main.Entities
{
    internal class Heater
    {
        private bool _isOn = false;

        public string On()
        {
            if (_isOn) return string.Empty;

            _isOn = true;
            return "Heater is on";
        }

        public string Off()
        {
            if (!_isOn) return string.Empty;

            _isOn = false;
            return "Heater is off";
        }

    }
}
