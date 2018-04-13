namespace Figures
{

    public class ManyFigures : IAreaFigure
    {
        private IAreaFigure[] table = null;

        public void AddFigure(IAreaFigure figure)
        {
            if (table == null)
            {
                table = new IAreaFigure[1];
                table[0] = figure;
            }
            else
            {
                int newSize = table.Length + 1;
                IAreaFigure[] temp = new IAreaFigure[newSize];

                for (int index = 0; index < newSize - 1; index++)
                {
                    temp[index] = table[index];
                }

                temp[newSize - 1] = figure;
                table = temp;
            }
        }

        public int GetArea()
        {
            if (table == null)
            {
                return 0;
            }

           int sum=0;

            foreach (IAreaFigure figure in table)
            {
                sum = sum + figure.GetArea();
            }

            return sum;
        }
    }
}
