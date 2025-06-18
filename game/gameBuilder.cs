using System;
using System.Collections.Generic;

public class GameBuilder
{

    private List<Agent> agentsList;
    private List<Agent> commandersList;
    private List<Sensor> sensorList;

    public GameBuilder(int numSensors, int numAgents, int numCommanders)
    {
        this.agentsList = new List<Agent>();
        this.commandersList = new List<Agent>();
        this.sensorList = new List<Sensor>();
        this.addAgents(numAgents);
        this.addCommandAgents(numCommanders);
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

    private void addCommandAgents(int num)
    {
        for (int i = 0; i < num; i++)
        {
            CommanderAgent agent = createAgents.createCommanderAgent();
            this.commandersList.Add(agent);
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

    public  List<Agent> GetCommanderAgents()
    {
        return this.commandersList;
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

    public void rebootSensors(int num)
    {
        this.sensorList = new List<Sensor>();
        this.addSensors(num);
    }
}