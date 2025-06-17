using System;
using System.Collections.Generic;

public class gameManager
{

    private AgentsList agentsList;
    private SensorList sensorList;
    private Investigation investigation;


    public gameManager(int numAgents, int numSensors)
    {
        agentsList = new AgentsList();
        sensorList = new SensorList();
        this.addAgents(numAgents);
        this.addSensors(numSensors);
    }

    private void addAgents(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Agent agent = createAgents.createAgent();
            this.agentsList.addAgent(agent);
        }
    }

    private void addSensors(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Sensor sensor = createSensors.createSensor();
            this.sensorList.addSensor(sensor);
        }
    }

    public List<Sensor> getSensors()
    {
        return this.sensorList.sensors;
    }

    public Investigation createInvestigation(int numAgent)
    {
        if (this.agentsList.agents.Count >= numAgent + 1) 
        {
            this.investigation = new Investigation(this.agentsList.agents[numAgent]);
        }

        return this.investigation;
    }

    public Sensor findSensorByName(string nameSensor)
    {
        Sensor sensor = null;
        foreach (Sensor s in this.sensorList.sensors)
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