using System;

public static class DistanceConverter
{
    //constはprivateであるべき
    private const double ratioF2M = 0.3048;
    private const double ratioM2F = 3.2808;

    //meter2feet
    public static double FeetToMeter(double feet)
    {
        return feet * ratioF2M;
    }

    //meter2feet
    public static double MeterToFeet(double meter)
    {
        return meter * ratioM2F;
    }

}
