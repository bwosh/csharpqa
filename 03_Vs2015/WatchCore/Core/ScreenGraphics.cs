using WatchCore.Enums;
using WatchCore.Interfaces;

namespace WatchCore.Core
{
    public class ScreenGraphics : IScreenGraphics
    {
        private readonly IScreen _screen;
        private readonly int _width;
        private readonly int _height;
        private readonly ScreenColor[] _screenColors;

        public int Width => _width;

        public int Height => _height;

        public ScreenGraphics(IScreen screen, int width, int height)
        {
            _screen = screen;
            _width = width;
            _height = height;
            _screenColors = new ScreenColor[width * height];
            Clear(ScreenColor.White);
        }

        private void Clear(ScreenColor color)
        {
            for (int i = 0; i < _width * _height; i++)
            {
                _screenColors[i] = color;
            }
        }

        public ScreenColor GetPixel(int x, int y)
        {
            return _screenColors[y * _width + x];
        }

        public void SetPixel(int x, int y, ScreenColor screenColor)
        {
            _screenColors[y * _width + x] = screenColor;
        }

        public void Draw()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    _screen.SetPixel(x, y, _screenColors[y * _width + x]);
                }
            }

            _screen.Draw();
        }
    }
}
