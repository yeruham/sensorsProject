using System;
using System.Collections.Generic;

public class MenuManager
{
    private gameManager gameManager;
    private Investigation investigation;

    public MenuManager(int numAgents, int numSensors)
    {
        this.gameManager = new gameManager(numAgents, numSensors);
        this.investigation = this.gameManager.createInvestigation(0);
    }

    public void startGame()
    {
        this.startMenu();
        this.showSensors();

        string nameSensor = "";
        bool agentExposed = false;

        do
        {
            nameSensor = this.selectSensor();
            agentExposed = this.resultInvestigation(nameSensor);

        } while (!agentExposed);

        this.showExposed();
    }

    private void startMenu()
    {
        Console.WriteLine($"Welcome to the SENSOR GAME : \n\nThe current agent is {this.investigation.agent.name}. \n" +
                          $"Each turn you can attach one of the sensors to the agent and try to expose him.\n");
    }

    private void showSensors()
    {
        Console.WriteLine($"The sensors are:");
        List<Sensor> sensors = this.gameManager.getSensors();
        foreach (Sensor sensor in sensors)
        {
            Console.Write($"sensor name: {sensor.name}, type: {sensor.type}. ");
        }
        Console.WriteLine("\n");
    }

    private string selectSensor()
    {
        Console.WriteLine("Write the name of sensor you want");
        string typeSensor = Console.ReadLine();
        return typeSensor;
    }

    private bool resultInvestigation(string nameSensor)
    {
        bool agentExposed = false;
        Dictionary<string, int> compatibleSensors = null;
        compatibleSensors = this.gameManager.startInvestigation(nameSensor);


        if (compatibleSensors != null)
        {
            if (compatibleSensors["numSensors"] == compatibleSensors["activeSensors"])
            {
                agentExposed = true;
            }
        }

        this.showResult(compatibleSensors);

        return agentExposed;
    }

    private void showResult(Dictionary<string, int> compatibleSensors)
    {
        if (compatibleSensors != null)
        {
            foreach(KeyValuePair<string, int> result in compatibleSensors)
            {
                Console.Write($"the {result.Key} is {result.Value}. ");
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine("\nThe agent name dose not exit, try again\n");
        }
    }

    private void showExposed()
    {
        Console.WriteLine($"\nWell done, the agent {this.investigation.agent.name} was exposed!!\n" +
                          $"Is rank is {this.investigation.agent.rank}\n" +
                          $"Is num sensors is {this.investigation.agent.numSensors}\n" +
                          $"By:");
        this.showActivateSensors();
    }

    private void showActivateSensors()
    {
        Sensor[] sensors = this.investigation.getAttachedSensors();
        foreach (Sensor sensor in sensors)
        {

            Console.WriteLine($"Sensor name: {sensor.name}, type: {sensor.type}. ");
        }
    }

}