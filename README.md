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
│   ├── createSensor.cs
│   └── sensorsList.cs
├── 📁 agents
│   ├── agent.cs
│   ├── createAgent.cs
│   └── agentList.cs
├── 📁 investigations
│   └── investigation.cs
└── 📁 game
    ├── gameManager.cs
    └── menuManager.cs```


## 📁 sensors

### `sensor.cs`
**Class: `Sensor`**  
Fields:
- `string name`
- `string type`  
Methods:
- `void Activate()`

---

### `createSensor.cs`  
**Static Class: `CreateSensor`**  
Methods:
- `Sensor CreateSensor()`

---

### `sensorsList.cs`  
**Class: `SensorsList`**  
Fields:
- `List<Sensor> sensors`  
Methods:
- `void AddSensor(Sensor sensor)`
- `void RemoveSensor(Sensor sensor)`
- `List<Sensor> GetSensors()`

---

## 📁 agents

### `agent.cs`  
**Class: `Agent`**  
Fields:
- `string name`
- `int rank`

---

### `createAgent.cs`  
**Static Class: `CreateAgent`**  
Methods:
- `Agent CreateAgent()`

---

### `agentList.cs`  
**Class: `AgentList`** 
Fields:
- `List<Agent> agents`  
Methods:
- `void AddAgent(Agent agent)`
- `void RemoveAgent(Agent agent)`
- `List<Agent> GetAgents()`

---

## 📁 investigations

### `investigation.cs`  
**Class: `Investigation`**  
Fields:
 
Methods:  


---

## 📁 game

### `gameManager.cs`  
**Class: `GameManager`**  
Fields:
 
Methods:


---

### `menuManager.cs`  
**Class: `MenuManager`**  
Fields:
  
Methods:  







