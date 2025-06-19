using System;
using System.Collections.Generic;
using System.Linq;

public class Investigation
{

    public Agent agent { get; }

    public Sensor[] attachedSensors { get; }
    public Investigation(Agent agent)
    {
        this.agent = agent;
        this.attachedSensors = this.agent.attachedSensors;
    }

    public bool fullList()
    {
        int numFull = 0;
        foreach (Sensor sensor in this.attachedSensors)
        {
            if (sensor != null)
            {
                numFull++;
            }
        }
        return (numFull == this.attachedSensors.Length);
    }
    public bool addSensor(Sensor sensor)
    {
        bool addSuccess = false;
        if (this.attachedSensors.Contains(sensor))
        {
            return addSuccess;
        }

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
        int numActive = 0;
        Dictionary<string, int> compatibleSensors = new Dictionary<string, int>();

        for (int i = 0; i < this.attachedSensors.Length; i++)
        {
            if (this.attachedSensors[i] == null)
            {
            }
            else
            {
                succeeded = this.attachedSensors[i].activate(this.agent);
                if (succeeded)
                {
                    numActive += 1;
                }
            }
        }

        compatibleSensors["numSensors"] = this.agent.numSensors;
        compatibleSensors["activeSensors"] = numActive;

        this.agent.resetActivateSensors();

        return compatibleSensors;
    }


}