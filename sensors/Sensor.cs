public class Sensor
{
    public string name { get; }
    public string type { get; }

    public Sensor(string name, string type)
    {
        this.name = name;
        this.type = type;
    }

    public bool activate(Agent agent)
    {
        bool succeeded = false;
        return succeeded;
    }


}