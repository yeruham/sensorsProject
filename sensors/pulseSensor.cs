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
        if (this.numSessions < 3)
        {
            this.numSessions++;
            return base.activate(agent);
        }
        else if(this.numSessions == 3)
        {
            this.showBreak();
            this.numSessions++;
        }

        return false;
    }

    public void showBreak()
    {
        Console.WriteLine($"\n After three uses - the sensor: {this.name}, type: {this.type}, broken.");
    }
}