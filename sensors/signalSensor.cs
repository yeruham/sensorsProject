using System;

public class SignalSensor: Sensor
{
    public SignalSensor(string name) : base(name)
    {
        this.type = "Signal";
    }

    public override bool activate(Agent agent)
    {
        this.ShowRankAgent(agent);
        return base.activate(agent);
    }

    public void ShowRankAgent(Agent agent)
    {
        Console.WriteLine($"The rank of agent {agent.name} is {agent.rank}.");
    }
}