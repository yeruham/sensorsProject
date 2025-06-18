using System;
using System.Collections.Generic;

public class MenuManager
{
    private GameBuilder gameBuilder;
    private List<Agent> agents;
    private InvestigationManager investigationManager;

    public MenuManager( int numSensors, int numAgents, int numCommanderAgents)
    {
        this.gameBuilder = new GameBuilder(numSensors, numAgents);
        this.agents = this.gameBuilder.getAgents();
    }

    public void startGame()
    {
        int numAgent = 0;
        bool continueGame = true;
        string message = Message.continueGame;
        int numLevel = 1;

        do {

            if (numAgent == this.agents.Count && numLevel == 1)
            {
                this.agentLevelingUp();
                message = Message.agentLevelingUp;
            }

            this.startInvestigation(numAgent);
            continueGame = this.continueGame(message);

            numAgent++;

        } while (continueGame && numAgent <= this.agents.Count);
      
    }

    private string createNewInvestigation(int num)
    {
        Agent agent = this.agents[num];
        this.investigationManager = new InvestigationManager(agent);
        return agent.name;
    }

    private void startInvestigation(int num)
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

    private bool continueGame(string message)
    {
        Message.printAnyMessage(message);
        string continueGame = Console.ReadLine();

        if (continueGame == "exit")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void agentLevelingUp()
    {
        this.gameBuilder.addCommandAgents(2);
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