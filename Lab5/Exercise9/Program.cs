using System;

namespace Exercise9
{
    class A: IComparable<A>
    {
        int n;
        string s;
        public int N
        {
            get;set;
        }

        public string Str
        {
            get;set;
        }


        public int CompareTo(A obj)
        {
            return this.N.CompareTo(obj.N);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A[] v = new A[4];
            v[0] = new A() { N = 10, Str = "431" };
            v[1] = new A() { N = 40, Str = "231" };
            v[2] = new A() { N = 8, Str = "131" };
            v[3] = new A() { N = 15, Str = "631" };
            foreach (var item in v)
            {
                Console.WriteLine($"{item.N} \t {item.Str}");
            }
            Array.Sort(v);
            Console.WriteLine("After sorting: \n\n");
            foreach (var item in v)
            {
                Console.WriteLine($"{item.N} \t {item.Str}");
            }
        }
    }
}
