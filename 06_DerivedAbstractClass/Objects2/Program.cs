using System;

namespace Objects2
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle(3, 4);
           // Console.WriteLine(r.GetDescription());

            ShowMeTheName(r);

            var s = new Square(7);
            var sAsRectangle = (Rectangle)s;

            #region Rectangle
            Write(r.Name);
            Write(r.Name2);
            #endregion

            #region Square
            Space();
            Write(s.Name);
            Write(s.Name2);
            #endregion

            #region Square as Rectangle
            Space();
            Write(sAsRectangle.Name);
            Write(sAsRectangle.Name2);
            #endregion

           /* #region Interfaces
            INamedObject[] data = { r, s, sAsRectangle };

            // foreach
            for (int i = 0; i < data.Length; i++)
            {
                Space();
                Write(data[i].Name);
                Write(data[i].Name2);
            }
            #endregion*/
        }

        private static void ShowMeTheName(INamedObject obj)
        {
            Console.WriteLine(">>>" + obj.Name + "<<<");
        }

        #region Not important
        private static void Space()
        {
            Console.WriteLine();
        }

        private static void Write(object o)
        {
            Console.WriteLine(o);
            Console.WriteLine("Press [ENTER] to continue...");
            Console.ReadLine();
        }
        #endregion
    }



}
