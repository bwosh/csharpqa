namespace Figures
{
    public class Rectangle : IAreaFigure
    {
        private int _a;
        private int _b;

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int GetArea()
        {
            return _b * _a;
        }
    }
}
