<<<<<<< startProject
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
    └── menuManager.cs
```

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





 







=======
# sensorsProject

## Sensor Activation and Comparison Workflow

This module handles the registration, activation, and evaluation of sensors for a given agent.

### 🔧 Workflow Overview

1. **Sensor Registration**  
   An `InvestigationSensor` is passed into the system and added to the internal list of sensors.

2. **Activation of All Sensors**  
   The `activateAll()` method is called, which iterates over the list and activates each sensor individually.

3. **Sensor Activation Process**  
   When each sensor is activated:
   - It receives an `Agent` object.
   - It calls `addSensor()`, which adds the sensor's type to the agent's internal list.
   - It then calls `compareSensors()`, which compares the agent’s current list of sensor types against a reference list and returns a numeric score indicating the degree of similarity.


class Sensor{

fields -

string name - type

methods - 

int activate(Agent agent) - agent.addSensor, agent.comparSensors

}

class Agent{

fields -

string name 
string rank
int numSensors
Dictinory<> typeSensors (key: typeSensor, value: num)
Dictinory<> Sensors (key: typeSensor, value: num)

methods -

addSensor() - add new sensor to sensors
comparSensors() - compar typeSensors to sensors 

}

class investigation{

fields -

Agent agent

List<Sensor> sensors

addSensor() - add new sensor to sensors

int activateAll() 


}
>>>>>>> main
