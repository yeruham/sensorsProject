public class Sensor
{
    public string name { get; }
    public string type { get; set; }

    public Sensor(string name)
    {
        this.name = name;
        this.type = "Audio";
    }

    public bool activate(Agent agent)
    {
        bool succeeded = false;

        succeeded = agent.sensorActivated(this.type);

        return succeeded;
    }


}