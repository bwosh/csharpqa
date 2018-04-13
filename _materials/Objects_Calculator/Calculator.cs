namespace Calculator
{
    public class Calculator
    {
        private decimal _value;
        private decimal _memory;

        public decimal GetCurrentValue()
        {
            return _value;
        }

        public void Add(decimal a)
        {
            _value += a;
        }

        public void Subtract(decimal b)
        {
            _value -= b;
        }

        public void MultipleBy(decimal b)
        {
            _value *= b;
        }

        public void DivideBy(decimal b)
        {
            _value /= b;
        }

        public void Clear()
        {
            _value = 0;
            _memory = 0;
        }

        // M+
        public void MemoryAdd()
        {
            _memory += _value;
        }

        // M-
        public void MemorySubtract()
        {
            _memory -= _value;
        }

        // MR
        public void MemoryRecall()
        {
            _value = _memory;
        }

        // MC
        public void MemoryClear()
        {
            _memory = 0;
        }

        public decimal GetMemoryValue()
        {
            return _memory;
        }
    }

}
