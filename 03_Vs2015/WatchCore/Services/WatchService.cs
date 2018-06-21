using WatchCore.Core;
using WatchCore.Enums;
using WatchCore.Interfaces;

namespace WatchCore.Services
{
    public class WatchService : IWatchService
    {
        private readonly ILogger _logger;
        private readonly IScreenGraphics _gfx;

        public WatchService(ILogger logger, IScreen screen, int width, int height)
        {
            _logger = logger;
            _gfx = new ScreenGraphics(screen, width, height);
        }

        public void ButtonEvent(ButtonEnum button, ButtonActionType buttonActionType)
        {
            _logger.Log("Click");
            //    var color = _gfx.GetPixel(x, y);
            //    _gfx.SetPixel(x, y, color == ScreenColor.Black ? ScreenColor.White : ScreenColor.Black);
            _gfx.Draw();
        }

        public void SecondTick()
        {
            _logger.Log("Second ticks");
            _gfx.Draw();
        }
    }
}
