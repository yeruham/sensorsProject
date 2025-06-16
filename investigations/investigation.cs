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
        for(int i = 0; i < this.attachedSensors.Length; i++)
        {
            if (this.attachedSensors[i] == null)
            {
                this.attachedSensors[i] = sensor;
                break;
            }
        }
    }

    public float activateSensors()
    {
        bool succeeded = false;
        float compatibleSensors = 0;

        for (int i = 0; i < this.attachedSensors.Length; i++)
        {
            succeeded = this.attachedSensors[i].activate(this.agent);
            if (!succeeded)
            {
                this.attachedSensors[i] = null;
            }
        }

        compatibleSensors = this.agent.compatibleSensors();
        return compatibleSensors;
    }
}