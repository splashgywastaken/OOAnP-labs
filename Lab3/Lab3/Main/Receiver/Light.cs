namespace Lab3.Main.Receiver
{
    public class Light
    {
        private bool _isOn = false;

        public string On()
        {
            if (_isOn) return string.Empty;

            _isOn = true;
            return "Light is on";
        }

        public string Off()
        {
            if (!_isOn) return string.Empty;

            _isOn = false;
            return "Light is off";
        }

    }
}
