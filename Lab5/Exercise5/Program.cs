using System;

namespace Exercise5
{
    class Program
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            MyLogger f1 = new MyLogger();
            MyClass myclass = new MyClass();
            MyClass.LogHandler myLogger = null;
            myLogger += new MyClass.LogHandler(Logger);
            myLogger += new MyClass.LogHandler(f1.logger);
            myclass.Process(myLogger);
            return;
        }
    }
}
