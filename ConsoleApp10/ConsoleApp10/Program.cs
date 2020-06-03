using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    //えぐざむ3.2だよ
    //やりかけだよ
    class Exam3_2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            var names = new List<string>
            {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            /* 3.2.1 Console.ReadLine
             */
            var line = Console.ReadLine();
            names.FindIndex(n => n == line);


            Console.WriteLine("Press Any Key...");
            Console.ReadKey();

        }
    }
}