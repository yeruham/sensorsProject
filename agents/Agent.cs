using System.Collections.Generic;

public class Agent
{
    public string name { get; }
    public int rank { get; }
    public int numSensors { get; }
    public Dictionary<string, int> typeOfSensors { get; set; }
    public int numActiveSensors { get; set; }
    public Dictionary<string, int> activeSensors { get; set; }

    public Agent(string name, int rank, Dictionary<string, int> typeOfSensors)
    {
        this.name = name;
        this.rank = rank;
        this.numSensors = typeOfSensors.Count;
        this.typeOfSensors = typeOfSensors;
        this.numActiveSensors = 0;
        this.activeSensors = new Dictionary<string, int>();
    }

    public bool sensorActivated(string sensorType)
    {
        if (!typeOfSensors.ContainsKey(sensorType))
        {
            return false;
        }

        int numThisType = typeOfSensors[sensorType];

        if (!activeSensors.ContainsKey(sensorType))
        {
            activeSensors[sensorType] = 1;
            this.numActiveSensors += 1;
            return true;
        }

        if (activeSensors[sensorType] < numThisType)
        {
            activeSensors[sensorType] += 1;
            this.numActiveSensors += 1;
            return true;
        }

        return false;
    }

    public void resetActivateSensors()
    {
        this.activeSensors = new Dictionary<string, int>();
        this.numActiveSensors = 0;
    }

}