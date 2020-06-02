using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //最初はいつもここから
            Console.WriteLine("Hello World!");
            //ここを変えれば出力する変換元がいくつからいくつまでかを制御できる
            int start = 9880;
            int stop = 9899;

            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(start, stop);
            }
            else
            {
                PrintMeterToFeetList(start, stop);
            }

            Console.WriteLine("Press Any Key...");

            Console.ReadKey();

        }

        static void PrintFeetToMeterList(int start, int stop) {

            for (int feet = start; feet <= stop; feet++)
            {

                double meter = DistanceConverter.FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);

            }

        }

        static void PrintMeterToFeetList(int start, int stop)
        {

            for (int meter = start; meter <= stop; meter++)
            {
                double feet = DistanceConverter.MeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} feet", meter, feet);
            }

        }


    }
}