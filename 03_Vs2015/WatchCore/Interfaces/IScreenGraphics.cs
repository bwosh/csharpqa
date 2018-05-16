using WatchCore.Enums;

namespace WatchCore.Interfaces
{
    public interface IScreenGraphics
    {
        ScreenColor GetPixel(int i, int i1);
        void SetPixel(int i, int i1, ScreenColor screenColor);
        void Draw();

        // TODO add Line, bar, etc.....
    }
}
