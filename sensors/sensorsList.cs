using System.Collections.Generic;

public class SensorList
{
    public List<Sensor> sensors;
    
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

}