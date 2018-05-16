using WatchCore.Enums;

namespace WatchCore.Interfaces
{
    public interface IWatchService
    {
        void ButtonEvent(ButtonEnum button, ButtonActionType buttonActionType);
        void SecondTick();
    }
}
