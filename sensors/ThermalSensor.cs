using System;
using System.Collections.Generic;

public class ThermalSensor: Sensor
{
    private Random random;
    private bool expose;
    public ThermalSensor(string name) : base(name)
    {
        this.type = "Thermal";
        this.random = new Random();
        this.expose = true;
    }

    public override bool activate(Agent agent)
    {
        bool success = base.activate(agent);
        if (success)
        {
            this.exposingWeakness(agent);
        }
        return success;
    }

    public void exposingWeakness(Agent agent)
    {
        if (this.expose)
        {
            Dictionary<string, int> weaknesses = agent.getWeaknesses();
            List<string> listWeaknesses = new List<string>();
            foreach (KeyValuePair<string, int> weakness in weaknesses)
            {
                for (int i = 0; i < weakness.Value; i++)
                {
                    listWeaknesses.Add(weakness.Key);
                }
            }

            int randWeakness = random.Next(0, listWeaknesses.Count);
            Console.WriteLine($"\none weakness of {agent.name} is {listWeaknesses[randWeakness]}.");
            
            this.expose = false;
        }
    }
}