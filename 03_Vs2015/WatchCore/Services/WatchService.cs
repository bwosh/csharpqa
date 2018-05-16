using System;
using WatchCore.Core;
using WatchCore.Enums;
using WatchCore.Interfaces;

namespace WatchCore.Services
{
    public class WatchService : IWatchService
    {
        private readonly ILogger _logger;
        private readonly int _width;
        private readonly int _height;
        private readonly IScreenGraphics _gfx;
        private readonly Random _random;

        public WatchService(ILogger logger, IScreen screen, int width, int height)
        {
            _logger = logger;
            _width = width;
            _height = height;
            _gfx = new ScreenGraphics(screen, width, height);
            _random = new Random();
        }

        public void ButtonEvent(ButtonEnum button, ButtonActionType buttonActionType)
        {
            // TODO add watch logic
            _logger.Log("Button event:" + button + ", " + buttonActionType);

            for (int i = 0; i < 100; i++)
            {
                InverseRandomPixel();
            }

            _gfx.Draw();
        }

        public void SecondTick()
        {
            _logger.Log("Second ticks");
            InverseRandomPixel();
            _gfx.Draw();
        }

        private void InverseRandomPixel()
        {
            int x = _random.Next(_width);
            int y = _random.Next(_height);
            var color = _gfx.GetPixel(x, y);
            _gfx.SetPixel(x, y, color == ScreenColor.Black ? ScreenColor.White : ScreenColor.Black);
        }
    }
}
