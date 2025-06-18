using System;
using System.Collections.Generic;
using System.Reflection;

public class CommanderAgent: Agent
{
    private int linkNum;
    public CommanderAgent(string name, int rank , Dictionary<string, int> typeOfSensors) : base(name, rank, typeOfSensors)
    {
        this.linkNum = 0;
    }

    public override bool sensorActivated(string sensorType)
    {
        bool suucess = base.sensorActivated(sensorType);
        this.counterAttack(sensorType);
        return suucess;
    }

    public void counterAttack(string sensorType)
    {
        if (this.linkNum >= (3 * this.attachedSensors.Length))
        {
            Console.WriteLine($"\nThe commander agent launch a counter attack and removed" +
                              $" {this.attachedSensors[0].name} from the  attached sensors");
            this.attachedSensors[0] = null;
            this.linkNum = 0;
        }
        else
        {
            this.linkNum++;
        }
    }


}