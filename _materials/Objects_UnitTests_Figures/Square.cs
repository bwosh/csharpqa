namespace Figures
{
    public class Square : IAreaFigure
    {
        private int _a;

        public Square(int a)
        {
            _a = a;
        }

        public int GetArea()
        {
            return _a * _a;
        }

        public void DuplicateSideSize()
        {
            _a = _a*2;
        }
    }
}
