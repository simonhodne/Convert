static public class Converter
{
    const double INCH_CM_RATIO = 2.54;
    const string MILLIMETERS = "mm";
    const string METERS = "m";
    static public double Convert(double inches, string unit)
    {
        double output = inches*INCH_CM_RATIO;
        if(unit == MILLIMETERS)
        {
            output = output*10.0;
        }
        else if(unit == METERS)
        {
            output = output/100.0;
        }

        return output;
    }
}