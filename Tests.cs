class Tests
{
    static string[] parseTestBasic = new string[] {"5.5", "-mm"};
    static string[] parseTestClutter = new string[] {"some", "clutter", "10", "aksdjfasdmfaoms", "15.57", "mm", "-cm"};

    static public void RunTests()
    {
        Test<double>(2.54, Converter.Convert(1,"cm"),"CM POS TEST");
        Test<double>(-2.54, Converter.Convert(-1,"cm"),"CM NEG TEST");
        Test<double>(25.4, Converter.Convert(1,"mm"),"MM POS TEST");
        Test<double>(-25.4, Converter.Convert(-1,"mm"),"MM NEG TEST");
        Test<double>(0.0254, Converter.Convert(1,"m"),"M POS TEST");
        Test<double>(-0.0254, Converter.Convert(-1,"m"),"M NEG TEST");
        Test<double>(3.81, Converter.Convert(1.5, "cm"), "DECIMAL TEST");
        Test<(double, string)>((5.5, "mm"), Program.ParseArgs(parseTestBasic), "PARSE TEST BASIC");
        Test<(double, string)>((10, "mm"), Program.ParseArgs(parseTestClutter), "PARSE TEST CLUTTER");
    }


    static void Test<T>(T expected, T actual, string description)
    {
        if(expected.Equals(actual)){
            Console.WriteLine("\u001b[32m" + description);
        }
        else{
            Console.WriteLine("\u001b[31m" + description);
        }
        Console.Write("\u001b[37m");
    }


}