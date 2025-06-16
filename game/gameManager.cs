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
            
        }
    }

    private void addSensors(int num)
    {
        for (int i = 0; i < num; i++)
        {

        }
    }

    public List<Sensor> getSensors()
    {
        return this.sensorList.sensors;
    }
    public Investigation createInvestigation(int numAgent)
    {
        if (this.agentsList.agents.Count > numAgent + 1) 
        {
            this.investigation = new Investigation(this.agentsList.agents[numAgent]);
        }

        return this.investigation;
    }

    public Dictionary<string, int> startInvestigation(string nameSensor)
    {
        Dictionary<string, int> compatibleSensors = null;
        Sensor sensor = this.findSensorByName(nameSensor);

        if (sensor != null)
        {
            this.investigation.addSensor(sensor);
            compatibleSensors = this.investigation.activateSensors();
        }

        return compatibleSensors;
    }

    private Sensor findSensorByName(string nameSensor)
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