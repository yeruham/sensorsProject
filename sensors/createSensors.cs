using System;
using System.Xml.Linq;

public static class createSensors
{
    private static Random _random = new Random();
    private static Func<string, Sensor>[] _typeSensors = { createAudioSensor, createPulseSensor, createThermalSensor, createSignalSensor };

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

    private static Sensor createSignalSensor(string name)
    {
        Sensor sensor = new SignalSensor(name);
        return sensor;
    }
    private static string createName()
    {
        int num = _random.Next(100, 500);
        char randLeeder = (char)('A' + _random.Next(26));
        string name = randLeeder + Convert.ToString(num);
        return name;
    }


}