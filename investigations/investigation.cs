using System;
using System.Collections.Generic;

public class Investigation
{
    private Sensor[] attachedSensors;
    public Agent agent { get; }

    public Investigation(Agent agent)
    {
        this.agent = agent;
        this.attachedSensors = new Sensor[agent.numSensors];
    }

    public void addSensor(Sensor sensor)
    {
        //this.printSensors();
        for (int i = 0; i < this.attachedSensors.Length; i++)
        {
            if (this.attachedSensors[i] == null)
            {
                this.attachedSensors[i] = sensor;
                break;
            }
        }
        //this.printSensors();
    }

    public Dictionary<string, int> activateSensors()
    {
        bool succeeded = false;
        Dictionary<string, int> compatibleSensors = new Dictionary<string, int>();
        for (int i = 0; i < this.attachedSensors.Length; i++)
        {
            if (this.attachedSensors[i] == null)
            {

            }
            else
            {
                succeeded = this.attachedSensors[i].activate(this.agent);
            }
            if (!succeeded)
            {
                this.attachedSensors[i] = null;
            }
        }

        compatibleSensors["numSensors"] = this.agent.numSensors;
        compatibleSensors["activeSensors"] = this.agent.numActiveSensors;

        this.agent.resetActivateSensors();

        return compatibleSensors;
    }

    public Sensor[] getAttachedSensors()
    {
        return this.attachedSensors;
    }

    public void printSensors()
    {
        foreach (Sensor sensor in this.attachedSensors)
        {
            if (sensor != null)
            {
                Console.WriteLine($"Sensor name: {sensor.name}, type: {sensor.type}. ");
            }
            else
            {
                Console.WriteLine("the sensor is nall");
            }
        }
    }
}