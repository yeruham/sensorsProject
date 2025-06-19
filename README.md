# sensors project
**by yeruham mendelson**

## Sensors Game

In this game, your goal is to expose secret agents by attaching sensors to them.  
Each agent has a **risk level** and a **unique combination** of sensor types required to reveal them.

The game includes several types of sensors.

When the game starts, a menu will appear where, on each turn, you can try to attach one of the available sensors to the current agent.

After each attempt, you will receive feedback indicating whether the sensor matches and the **percentage** by which the agent was exposed.

🎯 **Objective:**  
Fully expose the agent by attaching all the required sensors.

---

## Project Structure

```plaintext
📦 Project Root
├── 📁 sensors
│   ├── sensor.cs
│   ├── pulseSensor.cs
│   ├── ThermalSensor.cs
│   ├── signalSensor.cs
│   └── createSensor.cs
├── 📁 agents
│   ├── agent.cs
│   ├── commanderAgent.cs
│   └── createAgent.cs
├── 📁 investigations
│   └── investigation.cs
│   ├── invastigationManager.cs
│   └── invastigationMessagges.cs
└── 📁 game
    ├── gameBuilder.cs
    ├── menuManager.cs
    ├── mainManager.cs
    └── messags.cs
```

## 📁 sensors

### `sensor.cs`
**Class: `Sensor`**  
Fields:
- `string name`
- `string type`

Methods:
- `virtual bool Activate(Agent agent)`


### `PulseSensor.cs`
**Class: `PulseSensor` : `sensor`** 
Methods:
- `override bool Activate(Agent agent)`
- `void showBreak()`
---

### `ThernalSensor.cs`
**Class: `ThermalSensor` : `sensor`** 
Methods:
- `override bool ActivateAgent agent()`
- `void exposingWeakness()`
---

### `signalSensor.cs`
**Class: `SignalSensor` : `sensor`** 
Methods:
- `override bool Activate(Agent agent)`
- `void showRankAgent(Agent agent)`
---

### `createSensor.cs`  
**Static Class: `CreateSensor`**  
Methods:
- `Sensor CreateSensor()`
---


## 📁 agents

### `agent.cs`  
**Class: `Agent`**  
Fields:
- `string name`
- `int rank`
- `int numSensors`
- `Sensor[] attachedSensors`
  
Methods:
-`virtual bool sensorActivated(string sensorType)`
-`void resetActivateSensors()`
-`Dictionary<string, int> getWeaknesses()`


### `commanderAgent.cs`  
**Class: `CommanderAgent`: `Agent`**
Methods:
-`overide bool sensorActivated(string sensorType)`
- `void counterAttack(string sensorType)`
  

### `createAgent.cs`  
**Static Class: `CreateAgent`**  
Methods:
- `Agent CreateAgent()`
-`CommanderAgent createCommanderAgent()`



## 📁 investigations

### `investigation.cs`  
**Class: `Investigation`**  
Fields:
- `Agent agent`
- `Sensor[] attachedSensors`

Methods:
- `bool fullList()`
- `bool addSensor(Sensor sensor)`
- `bool removeSensor(Sensor sensor)`
- `Dictionary<string, int> activateSensors()`


### `investigationManager.cs`
**Class: `InvestigationManager`** 
Methods:
- `bool startInvestigation(Sensor sensor)`
- `bool InvestigationFull()`
- `removeSensor(Sensor sensor)`


### `investigationMessages.cs`
**Static Class: `InvestigationMessages`**
 Methods:
- `void showResult(Dictionary<string, int> compatibleSensors)`
- `void showSensors(Sensor[] sensors)`
- `void sensorDeleted(string name)`
- `void showExposed(Agent agent)`


 
## 📁 game

### `gameBuilder.cs`  
**Class: `GameBulider`**  
Fields:

Methods:

---

### `menuManager.cs`  
**Class: `MenuManager`**  
Fields:

Methods:

---
### `mainManager.cs`  
**Class: `MainManager`**  
Fields:

Methods:

---

### `messags.cs`  
**Static Class: `Messags`**  
Fields:

Methods:

---


