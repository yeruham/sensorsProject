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
        //this.startMenu();
        Massage.showMenu(this.investigation.agent.name);
        //this.showSensors();
        Massage.showSensors(this.gameManager.getSensors());

        Sensor sensor;
        bool agentExposed = false;

        do
        {
            sensor = this.selectSensor("Write the name of sensor you want\n");
            agentExposed = this.startInvestigation(sensor);

        } while (!agentExposed);

        //this.showExposed();
        Massage.showExposed(this.investigation.agent);
        Massage.showSensors(this.investigation.getAttachedSensors());
    }

    //private void startMenu()
    //{
    //    Console.WriteLine($"Welcome to the SENSOR GAME : \n\nThe current agent is {this.investigation.agent.name}. \n" +
    //                      $"Each turn you can attach one of the sensors to the agent and try to expose him.\n");
    //}

    //private void showSensors()
    //{
    //    Console.WriteLine($"The sensors are:");
    //    List<Sensor> sensors = this.gameManager.getSensors();
    //    foreach (Sensor sensor in sensors)
    //    {
    //        Console.WriteLine($"sensor name: {sensor.name}, type: {sensor.type}. ");
    //    }
    //    Console.WriteLine("\n");
    //}

    private Sensor selectSensor(string massage)
    {
        Sensor sensor = null;

        do
        {
            Console.WriteLine(massage);
            string nameSensor = Console.ReadLine();

            sensor = this.gameManager.findSensorByName(nameSensor);
            massage = "\nNo agent with that name found, try again\n";
        } 
        while (sensor == null);
        
        return sensor;
    }

    private bool startInvestigation(Sensor sensor)
    {
        bool agentExposed = false;
       
        this.investigation.addSensor(sensor);
        agentExposed = this.resultInvestigation();

        if (!agentExposed && this.investigation.fullList())
        {
            bool sensorDeleted = false;
            do
            {
                Sensor sensorToRemove = this.selectSensor($"\nYou have already chosen {this.investigation.agent.numSensors} sensors," +
                                                          $"\nto continue remove an existing sensor, by write his name\n");
                sensorDeleted = this.investigation.removeSensor(sensorToRemove);
            } while (!sensorDeleted);
        }

        return agentExposed;
    }
    
    private bool resultInvestigation()
    {
        bool agentExposed = false;
        Dictionary<string, int> compatibleSensors = null;
        compatibleSensors = this.investigation.activateSensors();

        if (compatibleSensors != null)
        {
            if (compatibleSensors["numSensors"] == compatibleSensors["activeSensors"])
            {
                agentExposed = true;
            }
        }

        Massage.showResult(compatibleSensors);
        return agentExposed;
    }

    //private void showResult(Dictionary<string, int> compatibleSensors)
    //{
    //    foreach (KeyValuePair<string, int> result in compatibleSensors)
    //        {
    //            Console.Write($"the {result.Key} is {result.Value}. ");
    //        }
    //    Console.WriteLine("\n");
    //}

    //private void showExposed()
    //{
    //    Console.WriteLine($"\nWell done, the agent {this.investigation.agent.name} was exposed!!\n" +
    //                      $"Is rank is {this.investigation.agent.rank}\n" +
    //                      $"Is num sensors is {this.investigation.agent.numSensors}\n" +
    //                      $"By:");
    //    this.showActivateSensors();
    //}

    //private void showActivateSensors()
    //{
    //    Sensor[] sensors = this.investigation.getAttachedSensors();
    //    foreach (Sensor sensor in sensors)
    //    {

    //        Console.WriteLine($"Sensor name: {sensor.name}, type: {sensor.type}. ");
    //    }
    //}

}