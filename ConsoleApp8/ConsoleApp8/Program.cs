using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 5, 5, 3, 9, 6, 7, 5, 8, 0, 10, 4 };

            //ラムダ式ってやつλ...
            //a % 2 == 1がjudgeの中身っぽい
            //aは勝手に推論する(ifで呼ばれたときに引数nに勝手に置き換わるっぽい)
            var count = Count(numbers, a => a.ToString().Contains("0"));
            Console.WriteLine(count);
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
        }

        //ここのjudgeの型が大事っぽい↓↓↓↓↓↓↓↓↓
        static int Count(int[] numbers, Predicate<int> judge)
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