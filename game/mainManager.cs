using System;

public class mainManager: MenuManager
{
    private int numSensors;
    public mainManager(int numSensors, int numAgents, int numCommanderAgents): base(numSensors, numAgents, numCommanderAgents)
    {
        this.numSensors = numSensors;
    }
    public void startGame()
    {
        Message.printAnyMessage(Message.startGame);
        bool continueGame = true;
        int currentLevel = 1;
        do
        {

            continueGame = this.startLevel();
            currentLevel = this.levelUp(currentLevel);

        } while (continueGame && currentLevel <= 2);
        Message.printAnyMessage(Message.endGame);
    }
    private bool startLevel()
    {
        int numAgent = 0;
        bool continueGame = true;
        do
        {

            this.startInvestigation(numAgent);
            this.gameBuilder.rebootSensors(numSensors);
            continueGame = this.continueGame(Message.continueGame);
            numAgent++;

        } while (continueGame && numAgent < this.agents.Count);
        return continueGame;
    }

    private int levelUp(int CurrentLevel)
    {
        this.agents = this.gameBuilder.GetCommanderAgents();
        Message.printAnyMessage(Message.agentLevelingUp);
        return CurrentLevel + 1;
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
}