using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //最初はいつもここから
            Console.WriteLine("Hello World!");

            if (args.Length >= 1 && args[0] == "-tom")
            {
                for (int feet = 1; feet <= 10; feet++)
                {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
                }
            }
            else
            {
                for (int meter = 1; meter <= 10; meter++)
                {
                    double feet = MeterToFeet(meter);
                    Console.WriteLine("{0} m = {1:0.0000} m", meter, feet);
                }
            }

            Console.ReadKey();

            Console.WriteLine("Press Any Key...");

        }

        //meter2feet
        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        //meter2feet
        static double MeterToFeet(int meter)
        {
            return meter * 3.2808;
        }

    }
}