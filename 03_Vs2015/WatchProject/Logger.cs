using System;
using System.Windows.Forms;
using WatchCore.Interfaces;

namespace WatchProject
{
    class Logger : ILogger
    {
        private readonly TextBox _textbox;
        private int _index = 0;

        public Logger(TextBox textbox)
        {
            _textbox = textbox;
        }

        public void Log(string message)
        {
            _index++;
            _textbox.Text = _index + ". " + message + Environment.NewLine + _textbox.Text;
        }
    }
}
