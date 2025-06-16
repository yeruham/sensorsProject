using System;

public static class createSensors
{
    private static Random _random = new Random();
    public static Sensor createSensor()
    {
        Sensor sensor = null;
        int num = _random.Next(1, 200);
        string name = Convert.ToString(num);
        if (num % 2 == 0)
        {
            sensor = new Sensor(name, "thermal");
        }
        else {
            sensor = new Sensor(name, "audio");
        }
        return sensor;
    }

}