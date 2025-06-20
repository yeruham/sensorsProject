﻿using System;
using System.Collections.Generic;
using System.Xml;

public static class Message
{
    public static string startGame = "----------  Welcome to the SENSOR GAME  ----------";
    public static string newSensor = "Write the name of sensor you want to add\n";
    public static string noSensor = "\nNo agent with that name found, try again\n";
    public static string noSensorInList = $"\nYou have already chosen all sensors," +
                                          $"\nto continue remove an existing sensor, by write his name\n";
    public static string continueGame = "\n----------  If you want to continue further investigation press any key. To exit press exit  ----------";
    public static string commanderAgents = "\n-----------------------     The level up, now the agent is commander agents.     -----------------------" +
                                           "\n----------  If you want to continue further investigation press any key. To exit press exit   ----------\n";
    public static string endGame = "\nThe game is over\n";
    public static void showMenu(string agentName)
    {
        Console.WriteLine($"\nThe current agent is {agentName}. \n" +
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


    public static void printAnyMessage(string message)
    {
        Console.WriteLine(message);
    }

 
}