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

    public bool addSensor(Sensor sensor)
    {
        bool addSuccess = false;
        for (int i = 0; i < this.attachedSensors.Length; i++)
        {
            if (this.attachedSensors[i] == null)
            {
                this.attachedSensors[i] = sensor;
                addSuccess = true;
                break;
            }
        }
        return addSuccess;
    }

    public bool removeSensor(Sensor sensor)
    {
        bool removeSuccess = false;
        for (int i = 0; i < this.attachedSensors.Length; i++)
        {
            if (this.attachedSensors[i] == sensor)
            {
                this.attachedSensors[i] = null;
                removeSuccess = true;
                break;
            }
        }
        return removeSuccess;
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