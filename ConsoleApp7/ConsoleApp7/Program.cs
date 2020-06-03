using System;

namespace ConsoleApp7
{
    class Exam3_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ここを変えれば出力する変換元がいくつからいくつまでかを制御できる
            int start = 1;
            int stop = 10;

            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintMeterToInchList(start, stop);
            }
            else
            {
                PrintInchToMeterList(start, stop);
            }

            Console.WriteLine("Press Any Key...");

            Console.ReadKey();
        }

        static void PrintInchToMeterList(int start, int stop)
        {

            for (int feet = start; feet <= stop; feet++)
            {

                double meter = DistanceConverter.InchToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);

            }

        }

        static void PrintMeterToInchList(int start, int stop)
        {

            for (int meter = start; meter <= stop; meter++)
            {
                double feet = DistanceConverter.MeterToInch(meter);
                Console.WriteLine("{0} m = {1:0.0000} feet", meter, feet);
            }

        }

    }
}