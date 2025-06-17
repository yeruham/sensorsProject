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

        Sensor sensor;
        bool agentExposed = false;

        do
        {
            sensor = this.selectSensor(Massage.newSensor);
            agentExposed = this.startInvestigation(sensor);

        } while (!agentExposed);

        this.showExposed();
    }

    private void startMenu()
    {
        Massage.showMenu(this.investigation.agent.name);
        Massage.showSensors(this.gameManager.getSensors());
    }


    private Sensor selectSensor(string massage)
    {
        Sensor sensor = null;

        do
        {
            Massage.WriteSensor(massage);
            string nameSensor = Console.ReadLine();

            sensor = this.gameManager.findSensorByName(nameSensor);
            massage = Massage.noSensor;
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
                Sensor sensorToRemove = this.selectSensor(Massage.noSensorInList);
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

    private void showExposed()
    {
        Massage.showExposed(this.investigation.agent);
        Massage.showSensors(this.investigation.getAttachedSensors());
    }
}