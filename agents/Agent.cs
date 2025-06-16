using System.Collections.Generic;

public class Agent
{
    public string name { get; }
    public int rank { get; }
    public int numSensors { get; }
    public Dictionary<string, int> typeOfSensors { get; set; }
    public Dictionary<string, int> activeSensors { get; set; }

    public Agent(string name, int rank, Dictionary<string, int> typeOfSensors)
    {
        this.name = name;
        this.rank = rank;
        this.numSensors = typeOfSensors.Count;
        this.typeOfSensors = typeOfSensors;
    }

    public int sensorActivated(string sensorType)
    {
        if (!typeOfSensors.ContainsKey(sensorType))
        {
            return 0;
        }

        int numThisType = typeOfSensors[sensorType];

        if (!activeSensors.ContainsKey(sensorType))
        {
            activeSensors[sensorType] = 1;
            return 1;
        }

        if (activeSensors[sensorType] < numThisType)
        {
            activeSensors[sensorType] += 1;
            return 1;
        }

        return 0;
    }

}