interface IDriveable
{
    void Move();
    void Stop();
}

// Class representing a road
class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int NumberOfLanes { get; set; }
    public int TrafficLevel { get; set; }

    public Road(double length, double width, int numberOfLanes, int trafficLevel)
    {
        Length = length;
        Width = width;
        NumberOfLanes = numberOfLanes;
        TrafficLevel = trafficLevel;
    }
}

// Class representing a vehicle
class Vehicle : IDriveable
{
    public string Type { get; set; }
    public double Speed { get; set; }
    public double Size { get; set; }

    public Vehicle(string type, double speed, double size)
    {
        Type = type;
        Speed = speed;
        Size = size;
    }

    public void Move()
    {
        Console.WriteLine($"{Type} is moving at speed {Speed}.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Type} has stopped.");
    }
}

// Class simulating traffic on roads
class TrafficSimulation
{
    public static void SimulateTraffic(Road road, List<Vehicle> vehicles)
    {
        Console.WriteLine($"Simulating traffic on a road with {road.NumberOfLanes} lanes.");

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }

        Console.WriteLine($"Traffic simulation on the road with {road.TrafficLevel} traffic level completed.\n");
    }
}
