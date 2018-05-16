using System;
using System.Drawing;
using System.Windows.Forms;
using WatchCore.Enums;
using WatchCore.Interfaces;
using WatchCore.Services;

namespace WatchProject
{
    public partial class Form1 : Form
    {
        private const int WIDTH = 128;
        private const int HEIGHT = 64;

        private readonly IScreen _screen;
        private readonly IWatchService _watchService;
        private readonly ILogger _logger;

        private bool _aPressed = false;
        private bool _bPressed = false;
        private bool _cPressed = false;
        private bool _dPressed = false;

        private int _second = -1;

        public Form1()
        {
            InitializeComponent();
            picScreen.Image = new Bitmap(WIDTH, HEIGHT);
            _screen = new Screen(picScreen);
            _logger = new Logger(txtLog);
            _watchService = new WatchService(_logger, _screen, WIDTH, HEIGHT);

            DemoCode();
        }

        public void DemoCode()
        {
            string text = "Hello, World!";
            _logger.Log(text);
        }

        private void btnA_Click(object sender, System.EventArgs e)
        {
            _watchService.ButtonEvent(ButtonEnum.A, ButtonActionType.Pressed);
            _watchService.ButtonEvent(ButtonEnum.A, ButtonActionType.DePressed);
        }

        private void btnB_Click(object sender, System.EventArgs e)
        {
            _watchService.ButtonEvent(ButtonEnum.B, ButtonActionType.Pressed);
            _watchService.ButtonEvent(ButtonEnum.B, ButtonActionType.DePressed);
        }

        private void btnC_Click(object sender, System.EventArgs e)
        {
            _watchService.ButtonEvent(ButtonEnum.C, ButtonActionType.Pressed);
            _watchService.ButtonEvent(ButtonEnum.C, ButtonActionType.DePressed);
        }

        private void btnD_Click(object sender, System.EventArgs e)
        {
            _watchService.ButtonEvent(ButtonEnum.D, ButtonActionType.Pressed);
            _watchService.ButtonEvent(ButtonEnum.D, ButtonActionType.DePressed);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'A' && !_aPressed)
            {
                _watchService.ButtonEvent(ButtonEnum.A, ButtonActionType.Pressed);
                _aPressed = true;
            }

            if (e.KeyValue == 'B' && !_bPressed)
            {
                _watchService.ButtonEvent(ButtonEnum.B, ButtonActionType.Pressed);
                _bPressed = true;
            }

            if (e.KeyValue == 'C' && !_cPressed)
            {
                _watchService.ButtonEvent(ButtonEnum.C, ButtonActionType.Pressed);
                _cPressed = true;
            }

            if (e.KeyValue == 'D' && !_dPressed)
            {
                _watchService.ButtonEvent(ButtonEnum.D, ButtonActionType.Pressed);
                _dPressed = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'A' && _aPressed)
            {
                _watchService.ButtonEvent(ButtonEnum.A, ButtonActionType.DePressed);
                _aPressed = false;
            }

            if (e.KeyValue == 'B' && _bPressed)
            {
                _watchService.ButtonEvent(ButtonEnum.B, ButtonActionType.DePressed);
                _bPressed = false;
            }

            if (e.KeyValue == 'C' && _cPressed)
            {
                _watchService.ButtonEvent(ButtonEnum.C, ButtonActionType.DePressed);
                _cPressed = false;
            }

            if (e.KeyValue == 'D' && _dPressed)
            {
                _watchService.ButtonEvent(ButtonEnum.D, ButtonActionType.DePressed);
                _dPressed = false;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            var nowSecond = DateTime.Now.Second;
            if (nowSecond != _second)
            {
                _second = nowSecond;
                _watchService.SecondTick();
            }
        }
    }
}
