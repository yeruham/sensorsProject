using System.Collections.Generic;

public class Agent
{
    public string name { get; }
    public int rank { get; }
    public int numSensors { get; }

    protected Dictionary<string, int> typeOfSensors;

    //protected int numActiveSensors;

    protected Dictionary<string, int> activeSensors;

    public Sensor[] attachedSensors;

    public Agent(string name, int rank, Dictionary<string, int> typeOfSensors)
    {
        this.name = name;
        this.rank = rank;
        this.typeOfSensors = typeOfSensors;
        this.numSensors = this.calcNumSensors();
        this.activeSensors = new Dictionary<string, int>();
        this.attachedSensors = new Sensor[this.numSensors];
    }

    public virtual bool sensorActivated(string sensorType)
    {
        if (!typeOfSensors.ContainsKey(sensorType))
        {
            return false;
        }

        int numThisType = typeOfSensors[sensorType];

        if (!activeSensors.ContainsKey(sensorType))
        {
            activeSensors[sensorType] = 1;
            return true;
        }

        if (activeSensors[sensorType] < numThisType)
        {
            activeSensors[sensorType] += 1;
            return true;
        }

        return false;
    }

    private int calcNumSensors()
    {
        int numSensors = 0;
        foreach(int num in this.typeOfSensors.Values)
        {
            numSensors += num;
        }

        return numSensors;
    } 

    public void resetActivateSensors()
    {
        this.activeSensors = new Dictionary<string, int>();
    }

    public Dictionary<string, int> getWeaknesses()
    {
        return this.typeOfSensors;
    }

}