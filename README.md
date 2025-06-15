# sensorsProject

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
