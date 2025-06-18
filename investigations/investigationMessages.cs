using System;
using System.Collections.Generic;

public static class InvestigationMassage
{
    public static void showResult(Dictionary<string, int> compatibleSensors)
    {
        Console.WriteLine();
        foreach (KeyValuePair<string, int> result in compatibleSensors)
        {
            Console.Write($"the {result.Key} is {result.Value}. ");
        }
        Console.WriteLine("\n");
    }


    public static void showSensors(Sensor[] sensors)
    {
        Console.WriteLine("The list of attached sensors is: ");
        foreach (Sensor sensor in sensors)
        {
            if (sensor != null)
            {
                Console.WriteLine($"Sensor name: {sensor.name}, type: {sensor.type}.");
            }
            else
            {
                Console.WriteLine($"Sensor name: null, type: null.");
            }
        }
        Console.WriteLine();
    }

    public static void sensorDeleted(string name)
    {
        Console.WriteLine($"\nThe {name} sensor removed successfully.");
    }

    public static void showExposed(Agent agent)
    {
        Console.WriteLine($"\nWell done, the agent {agent.name} was exposed!!\n" +
                          $"Is rank is {agent.rank}\n" +
                          $"Is num sensors is {agent.numSensors}\n" +
                          $"By:");
    }
}