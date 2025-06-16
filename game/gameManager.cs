using System.Collections.Generic;

public class gameManager
{

    private AgentsList agentsList;
    private SensorList sensorList;
    private Investigation investigation;


    public gameManager()
    {
        agentsList = new AgentsList();
        sensorList = new SensorList();
        this.addAgents(1);
        this.addSensors(2);
    }

    private void addAgents(int num)
    {
        for (int i = 0; i < num; i++)
        {
            
        }
    }

    private void addSensors(int num)
    {
        for (int i = 0; i < num; i++)
        {

        }
    }

    public Investigation createInvestigation(int numAgent)
    {
        if (this.agentsList.agents.Count > numAgent + 1) 
        {
            this.investigation = new Investigation(this.agentsList.agents[numAgent]);
        }

        return this.investigation;
    }

}