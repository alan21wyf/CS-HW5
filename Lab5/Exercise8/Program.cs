using System;

namespace Exercise8
{
    class A
    {
        int X;
        public abstract void f(int n);
        private virtual void g(uint n)
        {
            X = n as int;
        }
        public override string ToString()
        {
            return X.ToString();
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
