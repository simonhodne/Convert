class Program
{
    static void Main(string[] args)
    {
        (double, string) parsedArgs = ParseArgs(args);
        if(test)
        {
            Tests.RunTests();
        }

        if(!isValidUnit)
        {
            Console.WriteLine(INVALID_UNIT_ERROR);
        }
        else if(parsedArgs.Item1 == 0)
        {
            Console.WriteLine(NO_NUMBER_ERROR);
        }
        else
        {
            Console.WriteLine(Converter.Convert(parsedArgs.Item1, parsedArgs.Item2) + parsedArgs.Item2);
        }
    }

    const string INVALID_UNIT_ERROR = "Error: Unit entered is not supported, or no unit was entered";
    const string NO_NUMBER_ERROR = "Error: No number was entered, or the number entered is invalid";
    static string[] supportedUnits = {"cm", "mm", "m"};
    static bool isValidUnit = false;
    const string TEST = "test";
    static bool test = false;
    static public (double,string) ParseArgs(string[] args)
    {
        (double, string) parsedArgs = (0.0, "");
        foreach(string arg in args)
        {
            try
            {
                double tempDouble = double.Parse(arg);
                if(parsedArgs.Item1 == 0)
                {
                    parsedArgs.Item1 = tempDouble;
                }
            }
            catch
            {
                string tempArg = arg.Replace("-", "");
                tempArg = tempArg.ToLower();
                if(supportedUnits.Contains(tempArg) && parsedArgs.Item2 == "")
                {
                    parsedArgs.Item2 = tempArg;
                    isValidUnit = true;
                }
                else if(tempArg == TEST || tempArg == TEST.Substring(0,1))
                {
                    test = true;
                }
            }
        }

        return parsedArgs;
    }
}