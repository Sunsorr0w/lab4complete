using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Example simulation
        Road cityRoad = new Road(5000, 20, 2, 3);
        List<Vehicle> vehiclesOnCityRoad = new List<Vehicle>
        {
            new Vehicle("Car", 60, 3),
            new Vehicle("Bus", 40, 5),
            new Vehicle("Truck", 30, 8)
        };

        TrafficSimulation.SimulateTraffic(cityRoad, vehiclesOnCityRoad);

        // Optional: Add more roads and vehicles, simulate traffic on multiple roads

        Console.ReadLine(); // Pause to see the output
    }
}

