using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class MyClass
    {
        public delegate void LogHandler(string message);
        public void Process(LogHandler logHandle)
        {
            if (logHandle != null)
            {
                logHandle("begin");
            }
            if (logHandle != null)
            {
                logHandle("End");
            }
        }
    }
}
