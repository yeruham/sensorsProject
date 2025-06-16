public class Sensor
{
    public string name { get; }
    public string type { get; }

    private bool isActive;

    public Sensor(string name, string type)
    {
        this.name = name;
        this.type = type;
        this.isActive = false;
    }

    public bool activate(Agent agent)
    {
        bool succeeded = false;

        if (!this.isActive)
        {
            succeeded = agent.sensorActivated(this.type);
        }

        if (succeeded)
        {
            this.isActive = true;
        }

        return succeeded;
    }

    public void endActive()
    {
        this.isActive = false;
    }

}