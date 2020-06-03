using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!おまじない!!!
            Console.OutputEncoding = Encoding.UTF8;

            var numbers = new List<int> { 5, 5, 3, 9, 6, 7, 5, 8, 0, 10, 4 };
            var list = new List<string> { "orange", "apple", "grape", "strawberry" };

            numbers.ForEach(i => Console.Write(i + ","));

            //ラムダ式（最初にuenoが書いたコード）
            //a % 2 == 1がjudgeの中身
            //aは勝手に推論する(ifで呼ばれたときに引数nに勝手に置き換わる)
            var count = Count(numbers, a => a.ToString().Contains("0"));
            Console.WriteLine("\n奇数は{0}個です", count);

            //Listに対するExistの試用
            //条件指定するラムダ式よりもプリセットみたいに使える方が楽
            var startString = 'g';
            //結局ラムダ式書いてる(出力の編集用)
            //カンマ区切りがいらないならconsole.writeだけでOK
            list.ForEach(i => Console.Write(i + ","));
            Console.Write("の中には、{0}で始まる要素が", startString);
            if (list.Exists(s => s[0] == startString))
            {
                Console.WriteLine("存在します");
            }
            else
            {
                Console.WriteLine("存在しません");
            }


            //ここからyoshidaさんに書いていただいた

            // int型を受け取って２倍にするラムダメソッド。
            var mp2 = new Func<int, int>(x =>
            {
                return x * 2;
            });
            var val = mp2(10);
            Console.WriteLine(val);

            // int型を定数回プリントするメソッド。
            var mpp = new Action<int>(x =>
            {
                const int N = 2;
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(x);
                }
            });
            mpp(10);

            //改良版
            var predicate = new Predicate<int>(a =>
            {
                return a.ToString().Contains("0");
            });
            var count2 = Count(numbers, predicate);
            Console.WriteLine("奇数は{0}個です", count2);

            //ここまでyoshidaさんに書いていただいた

            //たとえば素数判定をこの中に入れた場合とか
            var isPrime = new Predicate<int>(num =>
            {
                if (num < 2) return false;
                else if (num == 2) return true;
                else if (num % 2 == 0) return false; // 偶数はあらかじめ除く

                double sqrtNum = Math.Sqrt(num);
                for (int i = 3; i <= sqrtNum; i += 2)
                {
                    if (num % i == 0)
                    {
                        // 素数ではない
                        return false;
                    }
                }
                // 素数である
                return true;

            });
            var count3 = Count(numbers, isPrime);
            Console.WriteLine("素数は{0}個です", count3);

            // 素数の出力をint型の変数n回プリントするメソッド。
            // 直上でカプセル化したメソッドの"isPrime"を使用する。
            var outputPrime = new Action<int>(n =>
            {
                int number = 1;
                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        int judgeNum = number;
                        if (isPrime(number++))
                        {
                            Console.Write(judgeNum);
                            Console.Write(",");
                            break;
                        }
                    }
                }
                Console.WriteLine();
            });

            DoAction(outputPrime, outputPrime);

            //funcの試用。
            //とりあえずCubeRootでも返してみようか
            var CubeRoot = new Func<double, double>(d =>
            {
                return Math.Pow(d, (double)1/3);
            });

            DoFunc(CubeRoot, CubeRoot);

            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
        }

        //Actionを受け取ってconstの数字に沿って実行する
        public static void DoAction(Action<int> ActionA, Action<int> ActionB)
        {

            const int NUM = 25;
            ActionA(NUM);
            ActionB(NUM);

        }

        //Funcを受け取ってconstの数字に沿って実行する
        public static void DoFunc(Func<double, double> FuncA, Func<double, double> FuncB)
        {

            const int NUM1 = 27;
            Console.WriteLine("{0:0.0}の立方根は{1:0.0}です", NUM1, FuncA(NUM1));
            const int NUM2 = 912673;
            Console.WriteLine("{0:0.0}の立方根は{1:0.0}です", NUM2, FuncB(NUM2));

        }

        //ここのjudgeの型が大事↓↓↓↓↓↓↓↓↓↓↓↓
        static int Count(List<int> numbers, Predicate<int> judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                {
                    count++;
                }
            }
            return count;
        }
    }

}