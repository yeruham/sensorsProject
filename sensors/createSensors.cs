using System;

public static class createSensors
{
    private static Random _random = new Random();
    private static string[] _typeSensors = { "thermal", "audio" };
    private static string[] _names = { "A23", "V5", "F23", "P12", "G3", "N7", "C45", "W34", "Q12" };
    public static Sensor createSensor()
    {
        string name = createName();
        string type = createType();
        Sensor sensor = new Sensor(name, type);
        return sensor;
    }

    private static string createName()
    {
        int num = _random.Next(0, _names.Length);
        string name = _names[num];
        _names[num] = Convert.ToString(_random.Next(100, 500));
        return name;
    }

    private static string createType()
    {
        int num = _random.Next(0, _typeSensors.Length);
        string type = _typeSensors[num];
        return type;
    }

}