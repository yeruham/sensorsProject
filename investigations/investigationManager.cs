using System.Collections.Generic;

public class InvestigationManager
{
    private Investigation investigation;

    public InvestigationManager(Agent agent)
    {
        this.investigation = new Investigation(agent);
    }

    public bool startInvestigation(Sensor sensor)
    {
        bool agentExposed = false;

        this.investigation.addSensor(sensor);

        Dictionary<string, int> compatibleSensors = null;
        compatibleSensors = this.investigation.activateSensors();

        if (compatibleSensors != null)
        {
            if (compatibleSensors["numSensors"] == compatibleSensors["activeSensors"])
            {
                this.agentExposed();
                agentExposed = true;
                return agentExposed;
            }
        }

        InvestigationMassage.showResult(compatibleSensors);
        InvestigationMassage.showSensors(this.investigation.attachedSensors);

        return agentExposed;

    }

    public void agentExposed()
    {
        InvestigationMassage.showExposed(this.investigation.agent);
        InvestigationMassage.showSensors(this.investigation.attachedSensors);
    }
    public bool InvestigationFull()
    {
        return this.investigation.fullList();
    }

    public void removeSensor(Sensor sensor)
    {
        bool sensorDeleted = false;
        sensorDeleted = this.investigation.removeSensor(sensor);
        if (sensorDeleted)
        {
            InvestigationMassage.sensorDeleted(sensor.name);
        }
    }

}