using System.Drawing;

namespace TheDevice
{
    public static class TheDevice
    {
        static int width = 30;
        static int height = 5;
        static byte[] data;

        static TheDevice()
        {
            Clear();
        }

        public static void Clear()
        {
            data = new byte[width*height];
            for(int i=0;i<width*height;i++)
            {
                data[i] = 0;
            }
        }

        public static int GetWidth()
        {
            return width;
        }

        public static int GetHeight()
        {
            return height;
        }

        public static void SetPixel(int x, int y, bool on)
        {
            if(x>=0 && x<width && y>=0 && y<height )
            {
                data[x + y*width] = on ? (byte)1:(byte)0;
            }
        }

        public static void Visualize()
        {
            System.Console.WriteLine($"{width}x{height}:");

            // TOP
            System.Console.Write("┌"); 
            for(int x=0;x<width;x++)
            {
               System.Console.Write("─"); 
            }
            System.Console.WriteLine("┐"); 

            // MIDDLE
            for(int y=0;y<height;y++)
            {
                System.Console.Write("│");
        
                for(int x=0;x<width;x++)
                {
                    System.Console.Write(data[x + y*width]==0 ? " " : "*");
                }
                System.Console.Write("│");
                System.Console.WriteLine();
            }

            // BOTTOM
            System.Console.Write("└"); 
            for(int x=0;x<width;x++)
            {
               System.Console.Write("─"); 
            }
            System.Console.WriteLine("┘");            

        }
    }
}