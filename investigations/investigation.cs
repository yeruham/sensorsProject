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

        for (int i = 0; i < this.attachedSensors.Length; i++)
        {
            if (this.attachedSensors[i] == null)
            {
                this.attachedSensors[i] = sensor;
                break;
            }
        }

    }

    public Dictionary<string, int> activateSensors()
    {
        bool succeeded = false;
        Dictionary<string, int> compatibleSensors;

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


        compatibleSensors = this.agent.exposureLevel();

        this.endActivateSensors();

        return compatibleSensors;
    }

    private void endActivateSensors()
    {
        this.agent.resetActivateSensors();

        for (int i = 0; i < this.attachedSensors.Length; i++)
        {
            if (this.attachedSensors[i] == null)
            {

            }
            else
            {
                this.attachedSensors[i].endActive();
            }
        }
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
                Console.WriteLine("the sensor is null");
            }
        }
    }
}