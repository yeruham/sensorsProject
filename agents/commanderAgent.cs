using System.Collections.Generic;
using System.Reflection;

public class CommanderAgent: Agent
{
    private int linkNum;
    public CommanderAgent(string name, int rank, Dictionary<string, int> typeOfSensors) : base(name, rank, typeOfSensors)
    {
        this.linkNum = 0;
    }

    public void counterAttack()
    {
        if (this.linkNum >= 3)
        {

        }
        else
        {
            this.linkNum++;
        }
    }
}