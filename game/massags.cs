using System;
using System.Collections.Generic;
using System.Xml;

public static class Massage
{
    public static string newSensor = "Write the name of sensor you want\n";
    public static string noSensor = "\nNo agent with that name found, try again\n";
    public static string noSensorInList = $"\nYou have already chosen all sensors," +
                                          $"\nto continue remove an existing sensor, by write his name\n";
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


    public static void WriteSensor(string massage)
    {
        Console.WriteLine(massage);
    }



    public static void showResult(Dictionary<string, int> compatibleSensors)
    {
        Console.WriteLine();
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

}