using System;
using System.Text;

namespace Multiplication
{
    class Matrix
    {
        private readonly int _columns;
        private readonly int _rows;
        private readonly float[] _values;

        public static long Additions { get; private set; }
        public static long Multiplications { get; private set; }
        public static long IndexCalculations { get; private set; }
        private static object _lock = new object();

        public Matrix(int columns, int rows, float[] values)
        {
            _columns = columns;
            _rows = rows;
            _values = values;
            if (values == null || values.Length != columns * rows)
            {
                throw new ApplicationException("Bad matrix");
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder(100);
            for (int row = 0; row < _rows; row++)
            {
                sb.Append("| ");
                for (int col = 0; col < _columns; col++)
                {
                    sb.Append(_values[GetIndex(col, row)]);
                    sb.Append(" ");
                }

                sb.AppendLine("|");
            }

            return sb.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        private int GetIndex(int col, int row)
        {
            lock (_lock)
            {
                IndexCalculations++;
            }
            return col + row * _columns;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a._columns != b._rows)
            {
                throw new ApplicationException("Cannot mutiply.");
            }

            lock (_lock)
            {
                Multiplications++;
            }
            var result = new Matrix(b._columns, a._rows, new float[b._columns * a._rows]);
            for (int col = 0; col < result._columns; col++)
                for (int row = 0; row < result._rows; row++)
                {
                    float value = 0;
                    for (int i = 0; i < a._columns; i++)
                    {
                        lock (_lock)
                        {
                            Additions++;
                            Multiplications++;
                        }

                        value += a._values[a.GetIndex(i, row)] * b._values[b.GetIndex(col, i)];
                    }
                    result._values[result.GetIndex(col, row)] = value;
                }
            return result;
        }
    }
}
