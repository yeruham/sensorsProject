using System.Collections.Generic;

public class AgentsList
{
    public List<Agent> agents;

    public AgentsList()
    {
        agents = new List<Agent>();
    }

    public void addSensor(Agent agent)
    {
        agents.Add(agent);
    }

    public void removeSensor(Agent agent)
    {
        agents.Remove(agent);
    }

}