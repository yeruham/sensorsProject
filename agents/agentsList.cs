using System.Collections.Generic;

public class AgentsList
{
    public List<Agent> agents;

    public AgentsList()
    {
        agents = new List<Agent>();
    }

    public void addAgent(Agent agent)
    {
        agents.Add(agent);
    }

    public void removeAgent(Agent agent)
    {
        agents.Remove(agent);
    }

}