using System;

namespace TheDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Draw single point (data types: int, bool)
            int x = 20;
            int y = 1;
            bool pixelVisible = true;

            TheDevice.SetPixel(x,y,pixelVisible);
            TheDevice.Visualize();

            // 2. Draw single line (for)
            // ┌──────────────────────────────┐
            // │******************************│
            // │                              │
            // │                              │
            // │                              │
            // │                              │
            // └──────────────────────────────┘

            TheDevice.Clear();
            for(int i=0; i<TheDevice.GetWidth(); i = i+1 )
            {
                TheDevice.SetPixel(i,0,pixelVisible);
            }
            TheDevice.Visualize();

            int a = 3;
            int b = 5;
            int c = ++a + b++ + ++b * ++b;

            TheDevice.Clear();
            int j=0;
            while(j<3)
            {
                j=j+1;
                TheDevice.SetPixel(1,j,pixelVisible);
            }

             TheDevice.Visualize();

            // if, for, while, do-while, foreach

            TheDevice.Clear();

            bool condition = 3 < 4;
            if (condition)
            {
                TheDevice.SetPixel(20, 3, pixelVisible);
            }
            TheDevice.Visualize();

            // 3. Draw all lines (for*for)
            // ┌──────────────────────────────┐
            // │******************************│
            // │******************************│
            // │******************************│
            // │******************************│
            // │******************************│
            // └──────────────────────────────┘    

            TheDevice.Clear();

            for (x = 0; x < TheDevice.GetWidth(); x++)
                for (y = 0; y < TheDevice.GetHeight(); y++)
                {
                    TheDevice.SetPixel(x, y, pixelVisible);
                }

            TheDevice.Visualize();

            // Mathematical operations
            int z = a + b; // Operations: * / + -
            int mod = 5 % 2;

            if (3 == 4)
            {
                // are equal
            }

            if (3 != 4)
            {
                // are not equal
            }

            bool c2 = 3==4 && 5==7;
            //c2 && S();

            if(3==3 && 4==4)
            {
                // AND
            }

            if(3==4 || 5==5)
            {
                // OR
            }

            // 4. Checkers (if,for)
            // ┌──────────────────────────────┐
            // │* * * * * * * * * * * * * * * │
            // │ * * * * * * * * * * * * * * *│
            // │* * * * * * * * * * * * * * * │
            // │ * * * * * * * * * * * * * * *│
            // │* * * * * * * * * * * * * * * │
            // └──────────────────────────────┘

            TheDevice.Clear();

            for (x = 0; x < TheDevice.GetWidth(); x++)
                for (y = 0; y < TheDevice.GetHeight(); y++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        TheDevice.SetPixel(x, y, pixelVisible);
                    }
                }

            TheDevice.Visualize();

            // 5. Border (if,for)
            // ┌──────────────────────────────┐
            // │******************************│
            // │*                            *│
            // │*                            *│
            // │*                            *│
            // │******************************│
            // └──────────────────────────────┘  

            TheDevice.Clear();

            for (x = 0; x < TheDevice.GetWidth(); x++)
                for (y = 0; y < TheDevice.GetHeight(); y++)
                {
                    if (x==0 || x == TheDevice.GetWidth()-1 || y==0 || y== TheDevice.GetHeight()-1)
                    {
                        TheDevice.SetPixel(x, y, pixelVisible);
                    }
                }

            TheDevice.Visualize();                      

            // 6. Draw first 40 pixels (while)
            // ┌──────────────────────────────┐
            // │******************************│
            // │**********                    │
            // │                              │
            // │                              │
            // │                              │
            // └──────────────────────────────┘            

            // Data types, (byte/short/long/float/double/decimal/datetime/char/string)

            // HW 7. Draw border with set size
            // SIZE=2:
            // ┌──────────────────────────────┐
            // │******************************│
            // │******************************│
            // │**                          **│
            // │******************************│
            // │******************************│
            // └──────────────────────────────┘            

            // HW 8. Draw horizontal lines with spacing
            // spacing=3
            // ┌──────────────────────────────┐
            // │*   *   *   *   *   *   *   * │
            // │*   *   *   *   *   *   *   * │
            // │*   *   *   *   *   *   *   * │
            // │*   *   *   *   *   *   *   * │
            // │*   *   *   *   *   *   *   * │
            // └──────────────────────────────┘            

            // HW 9. Draw first N checkers from the end 
            // N=20
            // ┌──────────────────────────────┐
            // │                              │
            // │                              │
            // │                              │
            // │                    * * * * * │
            // │ * * * * * * * * * * * * * * *│
            // └──────────────────────────────┘            

            // HW 10. Draw double checkers (n=2)
            // ┌──────────────────────────────┐
            // │**  **  **  **  **  **  **  **│
            // │**  **  **  **  **  **  **  **│
            // │  **  **  **  **  **  **  **  │
            // │  **  **  **  **  **  **  **  │
            // │**  **  **  **  **  **  **  **│
            // └──────────────────────────────┘     

            // HW 11. Draw bar (x1,y1,x2,y2)
            // x1=1, y1=2, x2=3, y2=2:
            // ┌──────────────────────────────┐
            // │ ***                          │
            // │ ***                          │
            // │                              │
            // │                              │
            // │                              │
            // └──────────────────────────────┘

        }
    }
}
