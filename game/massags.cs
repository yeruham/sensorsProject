using System;
using System.Collections.Generic;

public static class Massage
{
    public static void showMenu(string agentName)
    {
        Console.WriteLine($"Welcome to the SENSOR GAME : \n\nThe current agent is {agentName}. \n" +
                          $"Each turn you can attach one of the sensors to the agent and try to expose him.\n");
    }

    public static void showSensors(List<Sensor> sensors)
    {
        Console.WriteLine($"The sensors are:");
        foreach (Sensor sensor in sensors)
        {
            Console.WriteLine($"sensor name: {sensor.name}, type: {sensor.type}. ");
        }
        Console.WriteLine("\n");
    }

    public static void showResult(Dictionary<string, int> compatibleSensors)
    {
        foreach (KeyValuePair<string, int> result in compatibleSensors)
        {
            Console.Write($"the {result.Key} is {result.Value}. ");
        }
        Console.WriteLine("\n");
    }

    public static void showExposed(Agent agent)
    {
        Console.WriteLine($"\nWell done, the agent {agent.name} was exposed!!\n" +
                          $"Is rank is {agent.rank}\n" +
                          $"Is num sensors is {agent.numSensors}\n" +
                          $"By:");
    }

    public static void showSensors(Sensor[] sensors)
    {
        foreach (Sensor sensor in sensors)
        {

            Console.WriteLine($"Sensor name: {sensor.name}, type: {sensor.type}. ");
        }
    }

}