﻿using System;
using System.Collections.Generic;

public static class createAgents
{
    private static Random _random = new Random();
    private static string[] _typeWeaknesses = { "Thermal", "Audio", "Pulse", "Signal" };
    private static string[] _names = {"Daniel", "Yeruham", "Noa", "Eden", "Lior", "Avi", "Shara" };
    public static Agent createAgent()
    {
        string name = _createName();
        int rank = _createRank(2, 3);
        Dictionary<string, int> weaknesses = _createWeaknesses(rank);
        Agent agent = new Agent(name, rank, weaknesses);
        return agent;
    }

    public static CommanderAgent createCommanderAgent()
    {
        string name = _createName();
        int rank = _createRank(3, 5);
        Dictionary<string, int> weaknesses = _createWeaknesses(rank);
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
}