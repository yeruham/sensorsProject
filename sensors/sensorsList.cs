using System.Collections.Generic;

public class SensorList
{
    private List<Sensor> sensors;
    
    public SensorList()
    {
        sensors = new List<Sensor>();
    }

    public void addSensor(Sensor sensor)
    {
        sensors.Add(sensor);
    }

    public void removeSensor(Sensor sensor)
    {
        sensors.Remove(sensor);
    }

    public List<Sensor> getSensors()
    {
        return this.sensors;
    }
}