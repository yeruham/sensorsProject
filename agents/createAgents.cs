using System;
using System.Collections.Generic;

public static class createAgents
{
    private static Random _random = new Random();
    private static string[] _typeWeaknesses = { "Thermal", "Audio", "Pulse" };
    private static string[] _names = {"Daniel", "Yeruham", "Noa", "Eden", "Lior", "Avi", "Shara" };
    public static Agent createAgent()
    {
        string name = _createName();
        int rank = _createRank(2, 4);
        Dictionary<string, int> weaknesses = _createWeaknesses(rank);
        //printWeaknesses(weaknesses);
        Agent agent = new Agent(name, rank, weaknesses);
        return agent;
    }

    public static CommanderAgent createCommanderAgent()
    {
        string name = _createName();
        int rank = _createRank(5, 7);
        Dictionary<string, int> weaknesses = _createWeaknesses(rank);
        //printWeaknesses(weaknesses);
        CommanderAgent commander = new CommanderAgent(name, rank, weaknesses);
        return commander;
    }

    private static Dictionary<string, int> _createWeaknesses(int numWeaknesses)
    {
        Dictionary<string, int> weaknesses = new Dictionary<string, int>();

        for(int i = 0; i < numWeaknesses; i++){

            int locationType = _random.Next(0, _typeWeaknesses.Length);
            string weakness = _typeWeaknesses[locationType];

            if (weaknesses.ContainsKey(weakness))
            {
                weaknesses[weakness] += 1;
            }
            else
            {
                weaknesses[weakness] = 1;
            }
           
        }

        return weaknesses;
    }

    private static int _createRank(int startRange, int stopRange)
    {
        int rank = _random.Next(startRange, stopRange);
        return rank;
    }

    private static string _createName()
    {
        int num = _random.Next(0, _names.Length);
        string name = _names[num];
        return name;
    }

    //private static void printWeaknesses(Dictionary<string, int> weaknesses)
    //{
    //    foreach (KeyValuePair<string, int> weakness in weaknesses)
    //    {
    //        Console.WriteLine($"{weakness.Key} - {weakness.Value}");
    //    }
    //}
}