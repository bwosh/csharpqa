using System;

namespace Figures
{
    public class PiDer : IAreaFigure
    {
        private int _area;

        public PiDer(int area)
        {
            _area = area;
        }

        public PiDer(int n, int p)
        {
            _area = n + p;
        }

        public PiDer()
        {
            Console.WriteLine("Ale lenie , nie chce im się podać warości!!!!");
            _area = 666;
        }
        public int GetArea()
        {
            return _area;
        }
    }
}
