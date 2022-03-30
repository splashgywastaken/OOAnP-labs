using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Main.Entities
{
    internal class Door
    {
        private bool _isOpened = false;

        public string Open()
        {
            if (_isOpened) return string.Empty;

            _isOpened = true;
            return "Door is opened";
        }

        public string Close()
        {
            if (!_isOpened) return string.Empty;

            _isOpened = false;
            return "Door is closed";
        }

}
}
