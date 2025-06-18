using System;
using System.Collections.Generic;

public class GameBuilder
{

    private List<Agent> agentsList;
    private List<Sensor> sensorList;

    public GameBuilder(int numSensors, int numAgents)
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

    }

    public void addCommandAgents(int num)
    {
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

    public List<Agent> getAgents()
    {
        return this.agentsList;
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