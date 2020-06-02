using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {

        //C#プログラミングのイディオム/定石&パターン
        //p.42- 1章の演習問題1.1
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World!");

            //どら焼きオブジェクトの生成
            //初期値(小問1)
            AnotherNameSpace.Product BeanJamPancake = new AnotherNameSpace.Product(98, "どら焼き", 210, true);

            //税額を出力する(小問2)
            Console.WriteLine("{0} , {1}", BeanJamPancake.Name, BeanJamPancake.GetTax());

            //きちんとコンソールを止める親切設計
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();

        }
    }
}