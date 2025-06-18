using System;
using System.Collections.Generic;

public class GameBuilder
{

    private List<Agent> agentsList;
    private List<Sensor> sensorList;
    private Investigation investigation;


    public GameBuilder(int numAgents, int numSensors)
    {
        agentsList = new List<Agent>();
        sensorList = new List<Sensor>();
        this.addAgents(numAgents);
        this.addSensors(numSensors);
    }

    private void addAgents(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Agent agent = createAgents.createAgent();
            this.agentsList.Add(agent);
        }

        for (int i = 0; i < num; i++)
        {
            Agent agent = createAgents.createCommanderAgent();
            this.agentsList.Add(agent);
        }
    }


    private void addSensors(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Sensor sensor = createSensors.createSensor();
            this.sensorList.Add(sensor);
        }
    }

    public List<Sensor> getSensors()
    {
        return this.sensorList;
    }

    public Investigation createInvestigation(int numAgent)
    {
        if (this.agentsList.Count >= numAgent + 1) 
        {
            this.investigation = new Investigation(this.agentsList[numAgent]);
        }

        return this.investigation;
    }

    public Sensor findSensorByName(string nameSensor)
    {
        Sensor sensor = null;
        foreach (Sensor s in this.sensorList)
        {
            if (s.name == nameSensor)
            {
                sensor = s;
                break;
            }
        }
        return sensor;
    }

}