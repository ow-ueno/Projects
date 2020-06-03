using System;

//問題1.2だよ
namespace ConsoleApp4
{
    class Program
    {
        //入れ子クラスってやつ
        class MyClass
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        struct MyStruct
        {
            public int X { get; set; }
            public int Y { get; set; }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass myClass = new MyClass { X = 1, Y = 2 };
            MyStruct myStruct = new MyStruct { X = 1, Y = 2 };

            //1.2.2 PrintObjectsの呼び出し
            PrintObjects(myClass, myStruct);

            //1.2.3 呼び出し後の出力
            Console.WriteLine("@Main , MyClass : {0} , {1}", myClass.X, myClass.Y);
            Console.WriteLine("@Main , MyStruct : {0} , {1}", myStruct.X, myStruct.Y);

            //最後にきちんとコンソールを止める親切設計
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();

        }

        //1.2.1 PrintObjectsの定義
        static void PrintObjects(MyClass myClass,MyStruct myStruct)
        {
            myClass.X *= 2;
            myClass.Y *= 2;
            myStruct.X *= 2;
            myStruct.Y *= 2;

            Console.WriteLine("@PrintObjects , MyClass : {0} , {1}",myClass.X,myClass.Y);
            Console.WriteLine("@PrintObjects , MyStruct : {0} , {1}", myStruct.X,myStruct.Y);
        }

    }



}