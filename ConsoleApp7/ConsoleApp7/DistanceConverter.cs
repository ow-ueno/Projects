using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class DistanceConverter
    {

        //constはprivateであるべき
        private const double RATIOI2M = 0.0254;
        private const double RATIOM2I = 39.3700;

        //meter2feet
        public static double InchToMeter(double feet)
        {
            return feet * RATIOI2M;
        }

        //meter2feet
        public static double MeterToInch(double meter)
        {
            return meter * RATIOM2I;
        }

    }
}
