namespace InOut
{
    internal class MyClass
    {
        private int _x;

        public MyClass(int x)
        {
            _x = x;
        }

        public int X
        {
            get { return _x; }
        }

        public void Increase()
        {
            _x++;
        }

        public override string ToString()
        {
            return string.Format("MyClass: x={0}", _x);
        }
    }
}