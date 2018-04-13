using System;
using System.Threading;

namespace SeleniumFinal.Core
{
    public abstract class Base
    {
        protected static void WaitABit()
        {
            Thread.Sleep(2000);
        }

        protected void Log(string text)
        {
            string fullText = string.Format("{0} {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), text);
            Console.WriteLine(fullText);
        }
    }
}
