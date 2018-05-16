using System;
using System.Drawing;
using System.Windows.Forms;
using WatchCore.Enums;
using WatchCore.Interfaces;

namespace WatchProject
{
    class Screen : IScreen
    {
        private readonly PictureBox _picScreen;
        private readonly Bitmap _image;
        private readonly Graphics _gfx;

        public Screen(PictureBox picScreen)
        {
            _picScreen = picScreen;
            _image = (Bitmap)_picScreen.Image;
            _gfx = Graphics.FromImage(_image);
        }

        public void SetPixel(int x, int y, ScreenColor color)
        {
            _image.SetPixel(x,y, ToColor(color));
        }

        public void Draw()
        {
            _picScreen.Refresh();
        }

        private Color ToColor(ScreenColor color)
        {
            switch (color)
            {
                case ScreenColor.White:
                    return Color.White;
                case ScreenColor.Black:
                    return Color.Black;
                default:
                    throw new ArgumentOutOfRangeException(nameof(color), color, null);
            }
        }
    }
}
