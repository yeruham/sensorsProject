using System;

public class PulseSensor: Sensor
{
    private int numSessions;
    public PulseSensor(string name) : base(name) 
    {
        this.type = "Pulse";
        numSessions = 0;
    }

    public override bool activate(Agent agent)
    {
        if (numSessions < 3)
        {
            numSessions++;
            return base.activate(agent);
        }
        else
        {
            Console.WriteLine($"\n After three uses - the sensor: {this.name}, type: {this.type}, broken.");
            return false;
        }

    }
}