using System;
using System.Xml.Linq;

public static class createSensors
{
    private static Random _random = new Random();
    private static Func<string, Sensor>[] _typeSensors = { createAudioSensor, createPulseSensor, createThermalSensor };


    private static string[] _names = { "A23", "V5", "F23", "P12", "G3", "N7", "C45", "W34", "Q12" };
    public static Sensor createSensor()
    {
        string name = createName();
        int num = _random.Next(0, _typeSensors.Length);
        Sensor sensor = _typeSensors[num](name);
        return sensor;
    }

    private static Sensor createAudioSensor(string name)
    {
        Sensor sensor = new Sensor(name);
        return sensor;
    } 
    private static Sensor createThermalSensor(string name)
    {
        Sensor sensor = new ThermalSensor(name);
        return sensor;
    }

    private static Sensor createPulseSensor(string name)
    {
        Sensor sensor = new PulseSensor(name);
        return sensor;
    }
    private static string createName()
    {
        int num = _random.Next(0, _names.Length);
        string name = _names[num];
        _names[num] = Convert.ToString(_random.Next(100, 500));
        return name;
    }


}