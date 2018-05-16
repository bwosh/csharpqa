using WatchCore.Enums;

namespace WatchCore.Interfaces
{
    public interface IScreen
    {
        void SetPixel(int x, int y, ScreenColor color);
        void Draw();
    }
}
