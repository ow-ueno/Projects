using System;
using System.Text;
using System.Collections.Generic;
using AnotherNameSpace;

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
            //それ以外にもいろいろ追加
            //初期値(小問1)
            List<Product> Products = new List<Product>();
            Product BeanJamPancake = new Product(98, "どら焼き", 210, true);
            Products.Add(BeanJamPancake);
            Product Computer = new Product(99, "パソコン", 50000, false);
            Products.Add(Computer);
            Product Junos = new Product(100, "ゆず", 300, true);
            Products.Add(Junos);
            Product Monitor = new Product(101, "モニター", 12000, false);
            Products.Add(Monitor);

            //税額を出力する(小問2)

            foreach (Product p in Products) {
                Console.WriteLine("{0}の価格は{1}円です。", p.Name, p.Price);
                Console.Write("{0}は軽減税率の対象", p.Name);
                if (p.IsReduced) {
                    Console.Write("な");
                }
                else
                {
                    Console.Write("ではない");
                }
                Console.Write("ので、");
                Console.WriteLine("{0}の税額は{1}円です。", p.Name, p.GetTax());
                Console.WriteLine("{0}の税込価格は{1}円です。", p.Name, p.GetPriceIncludingTax());
            }

            //最後にきちんとコンソールを止める親切設計
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();

        }
    }
}