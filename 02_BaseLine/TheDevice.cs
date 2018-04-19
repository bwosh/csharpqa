using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

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

        public static void Resize(int width, int height)
        {
            TheDevice.width = width;
            TheDevice.height = height;
            Clear();
        }

        public static void Clear()
        {
            data = new byte[width * height];
            for (int i = 0; i < width * height; i++)
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
            if (x >= 0 && x < width && y >= 0 && y < height)
            {
                data[x + y * width] = on ? (byte)1 : (byte)0;
            }
        }

        private static void CreateGraphics()
        {
            using (Bitmap im = new Bitmap(width, height))
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        var v = data[x + y * width];
                        Color c;
                        if(v==1)
                        {
                            c = Color.FromArgb(255, 255, 50, 50);
                        }else{
                            c = Color.FromArgb(255, 100, 110, 120);
                        }

                        im.SetPixel(x, y, c);
                    }
                }
                var t = DateTime.UtcNow.ToString("yyyyMMdd-HHmmss-fffff");
                im.Save(t + ".png", ImageFormat.Bmp);
            }
        }

        private static void VisualizeAsText()
        {
            System.Console.WriteLine($"{width}x{height}:");

            // TOP
            System.Console.Write("┌");
            for (int x = 0; x < width; x++)
            {
                System.Console.Write("─");
            }
            System.Console.WriteLine("┐");

            // MIDDLE
            for (int y = 0; y < height; y++)
            {
                System.Console.Write("│");

                for (int x = 0; x < width; x++)
                {
                    System.Console.Write(data[x + y * width] == 0 ? " " : "*");
                }
                System.Console.Write("│");
                System.Console.WriteLine();
            }

            // BOTTOM
            System.Console.Write("└");
            for (int x = 0; x < width; x++)
            {
                System.Console.Write("─");
            }
            System.Console.WriteLine("┘");

        }

        public static void Visualize(bool textMode = false)
        {
            if (textMode)
            {
                VisualizeAsText();
            }
            else
            {
                CreateGraphics();
            }
        }
    }
}