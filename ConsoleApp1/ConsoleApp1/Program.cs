using System;

namespace ConsoleApp1
{
    class App1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hoge World!");

            MyPoint a = new MyPoint(10, 20, 30);
            MyPoint b = a;

            a.X = 80;
            a.Z = 100;

            Console.WriteLine("a = ( {0} , {1} )", a.X, a.Y);
            Console.WriteLine("b = ( {0} , {1} )", b.X, b.Y);

            Console.ReadKey();

        }
    }

    class MyPoint
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public MyPoint(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}