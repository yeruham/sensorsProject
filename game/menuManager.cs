using System;
using System.Collections.Generic;

public class MenuManager
{
    protected GameBuilder gameBuilder;
    protected List<Agent> agents;
    private InvestigationManager investigationManager;

    public MenuManager( int numSensors, int numAgents, int numCommanderAgents)
    {
        this.gameBuilder = new GameBuilder(numSensors, numAgents, numCommanderAgents);
        this.agents = this.gameBuilder.getAgents();
    }

    protected void startInvestigation(int num)
    {
        string agentName = this.createNewInvestigation(num);
        this.startMenu(agentName);

        Sensor sensor;
        bool agentExposed = false;

        do
        {
            bool investigationFull = this.investigationManager.InvestigationFull();
            if (investigationFull)
            {
                sensor = this.selectSensor(Message.noSensorInList);
                this.investigationManager.removeSensor(sensor);
            }
            else
            {
                sensor = this.selectSensor(Message.newSensor);
                agentExposed = this.investigationManager.startInvestigation(sensor);
            }

        } while (!agentExposed);
    }

    private string createNewInvestigation(int num)
    {
        Agent agent = this.agents[num];
        this.investigationManager = new InvestigationManager(agent);
        return agent.name;
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
            Message.printAnyMessage(massage);
            string nameSensor = Console.ReadLine();

            sensor = this.gameBuilder.findSensorByName(nameSensor);
            massage = Message.noSensor;
        } 
        while (sensor == null);
        
        return sensor;
    }

}