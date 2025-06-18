using System;
using System.Collections.Generic;

public class MenuManager
{
    private GameBuilder gameBuilder;
    private List<Agent> agents;
    private InvestigationManager investigationManager;

    public MenuManager(int numAgents, int numSensors)
    {
        this.gameBuilder = new GameBuilder(numAgents, numSensors);
        this.agents = this.gameBuilder.getAgents();
    }

    public void startGame()
    {
        int numAgent = 0;
        Agent agent = this.agents[numAgent];
        this.investigationManager = new InvestigationManager(agent);
        this.startMenu(agent.name);

        Sensor sensor;
        bool agentExposed = false;

        do
        {
            bool investigationFull = this.investigationManager.InvestigationFull();
            if (investigationFull)
            {
                Sensor sensorToRemove = this.selectSensor(Message.noSensorInList);
                this.investigationManager.removeSensor(sensorToRemove);
            }
            else
            {
                sensor = this.selectSensor(Message.newSensor);
                agentExposed = this.investigationManager.startInvestigation(sensor);

            }

        } while (!agentExposed);


    }

    private void startMenu(string name)
    {
        Message.showMenu(name);
        Message.showSensors(this.gameBuilder.getSensors());
    }


    private Sensor selectSensor(string massage)
    {
        Sensor sensor = null;

        do
        {
            Message.WriteSensor(massage);
            string nameSensor = Console.ReadLine();

            sensor = this.gameBuilder.findSensorByName(nameSensor);
            massage = Message.noSensor;
        } 
        while (sensor == null);
        
        return sensor;
    }


    private void showExposed(string name)
    {

    }
}