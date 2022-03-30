using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Main.Entities
{
    internal class Fan
    {
        private bool _isOn = false;

        public string On()
        {
            if (_isOn) return string.Empty;

            _isOn = true;
            return "Fan is on";
        }

        public string Off()
        {
            if (!_isOn) return string.Empty;

            _isOn = false;
            return "Fan is off";
        }

    }
}
