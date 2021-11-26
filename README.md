# Traffic_Simulation
## Threading 

Threading is a technique that allows an application to execute several operations 
simultaneously in the same space or environment. 

## Proyect

First of all this project was based on a traffic simulation in order to test what are the threads applied in a program. 
With this program we were able to observe this in the following way:

![Image of simulation](traffic_simulation.png)

As we can see the cars will have a spawn at the beginning of the map, and they will have a default 
speed which can be increased or decreased through unity and the buttons set in the program.

Also when the lights turn red the car that is at that traffic light will make a stop and then when it 
turns green it will go again to the end where the car object will be destroyed so it can spawn again.

Regarding the threading in this project, it was implemented in the following way:

```csharp
IEnumerator trafficLights()
{
  while(true)
  {
    tlGreen();
    yield return new WaitForSeconds(7);
    tlYellow();
    yield return new WaitForSeconds(4);
    tlRed();
    yield return new WaitForSeconds(11);
  }
}
```
It was done this way to control the flow of traffic lights and the way in which 
it will run specifically so that there are no collisions within the program.
