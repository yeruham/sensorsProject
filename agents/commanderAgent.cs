using System;
using System.Collections.Generic;
using System.Reflection;

public class CommanderAgent: Agent
{
    private int linkNum;
    //private Random random;
    public CommanderAgent(string name, int rank, Dictionary<string, int> typeOfSensors) : base(name, rank, typeOfSensors)
    {
        this.linkNum = 0;
        //this.random = new Random();
    }

    public override bool sensorActivated(string sensorType)
    {
        this.counterAttack();
        return base.sensorActivated(sensorType);
    }
    public void counterAttack()
    {
        if (this.linkNum >= 3)
        {
            for(int i = this.numSensors - 1; i > -1; i--)
            {
                if (this.attachedSensors[i] != null)
                {
                    Console.WriteLine($"\nThe commander agent launch a counter attack and removed" +
                                      $" {this.attachedSensors[i]} from the  attached sensors");
                    this.attachedSensors[i] = null;
                    this.linkNum = 0;
                    break;
                }
            }
        }
        else
        {
            this.linkNum++;
        }
    }
}