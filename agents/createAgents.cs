using System.Collections.Generic;

public static class createAgents
{
    public static Agent createAgent()
    {
        Agent agent = new Agent("yeruham", 3, new Dictionary<string, int> { { "thermal", 1 }, { "audio", 2 } });
        return agent;
    }
}