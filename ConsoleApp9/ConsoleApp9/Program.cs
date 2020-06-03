using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    //LINQ
    //3.1演習
    class Exam3_1
    {
        static void Main(string[] args)
        {
            //とにかく
            Console.WriteLine("Hello World!");

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            /*             
            3.1.1 Exists
             */
            var isDivisible = numbers.Exists(i => i % 9 == 0 || i % 8 == 0);
            Console.WriteLine(isDivisible);

            /*             
            3.1.3 LINQ.Where
             */
            var over50 = numbers.Where(i => i >= 50);
            foreach (int i in over50)
                Console.WriteLine(i);
            //↑queryは暗黙的にIEnumerable<int>
            //だいたいlistと同じように使える
            //(但しquery.foreachとはできない)

            /*             
            3.1.4 LINQ.Select
             */
            var multi2 = numbers.Select(i => i * 2);
            foreach (int i in multi2)
                Console.WriteLine(i);

            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
            
        }
    }
}
 