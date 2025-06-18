using System;

public class SignalSensor: Sensor
{
    public SignalSensor(string name) : base(name)
    {
        this.type = "Signal";
    }

    public override bool activate(Agent agent)
    {
        bool success = base.activate(agent);
        if (success)
        {
            this.showRankAgent(agent);
        }
        return success;
    }

    public void showRankAgent(Agent agent)
    {
        Console.WriteLine($"\nThe rank of agent {agent.name} is {agent.rank}.");
    }
}