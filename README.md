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
