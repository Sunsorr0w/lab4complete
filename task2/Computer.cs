interface IConnectable
{
    void Connect(Computer device);
    void Disconnect(Computer device);
    void TransferData(Computer source, Computer destination, string data);
}

// Base class for computers
class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OperatingSystem { get; set; }

    // Constructor
    public Computer(string ipAddress, int power, string operatingSystem)
    {
        IPAddress = ipAddress;
        Power = power;
        OperatingSystem = operatingSystem;
    }
}

// Derived class for servers
class Server : Computer, IConnectable
{
    // Additional properties for servers
    public int StorageCapacity { get; set; }

    // Constructor
    public Server(string ipAddress, int power, string operatingSystem, int storageCapacity)
        : base(ipAddress, power, operatingSystem)
    {
        StorageCapacity = storageCapacity;
    }

    // Implementation of IConnectable interface
    public void Connect(Computer device)
    {
        Console.WriteLine($"Server {IPAddress} connected to {device.IPAddress}");
    }

    public void Disconnect(Computer device)
    {
        Console.WriteLine($"Server {IPAddress} disconnected from {device.IPAddress}");
    }

    public void TransferData(Computer source, Computer destination, string data)
    {
        Console.WriteLine($"Data transferred from {source.IPAddress} to {destination.IPAddress}: {data}");
    }
}

// Derived class for workstations
class Workstation : Computer, IConnectable
{
    // Additional properties for workstations
    public string UserName { get; set; }

    // Constructor
    public Workstation(string ipAddress, int power, string operatingSystem, string userName)
        : base(ipAddress, power, operatingSystem)
    {
        UserName = userName;
    }

    // Implementation of IConnectable interface
    public void Connect(Computer device)
    {
        Console.WriteLine($"Workstation {IPAddress} connected to {device.IPAddress}");
    }

    public void Disconnect(Computer device)
    {
        Console.WriteLine($"Workstation {IPAddress} disconnected from {device.IPAddress}");
    }

    public void TransferData(Computer source, Computer destination, string data)
    {
        Console.WriteLine($"Data transferred from {source.IPAddress} to {destination.IPAddress}: {data}");
    }
}

// Derived class for routers
class Router : Computer, IConnectable
{
    // Additional properties for routers
    public List<Computer> ConnectedDevices { get; set; }

    // Constructor
    public Router(string ipAddress, int power, string operatingSystem)
        : base(ipAddress, power, operatingSystem)
    {
        ConnectedDevices = new List<Computer>();
    }

    // Implementation of IConnectable interface
    public void Connect(Computer device)
    {
        ConnectedDevices.Add(device);
        Console.WriteLine($"Router {IPAddress} connected to {device.IPAddress}");
    }

    public void Disconnect(Computer device)
    {
        ConnectedDevices.Remove(device);
        Console.WriteLine($"Router {IPAddress} disconnected from {device.IPAddress}");
    }

    public void TransferData(Computer source, Computer destination, string data)
    {
        if (ConnectedDevices.Contains(destination))
        {
            Console.WriteLine($"Data routed from {source.IPAddress} to {destination.IPAddress}: {data}");
        }
        else
        {
            Console.WriteLine($"Destination {destination.IPAddress} is not connected to Router {IPAddress}");
        }
    }
}

// Class modeling the network
class Network
{
    private List<Computer> devices;

    public Network()
    {
        devices = new List<Computer>();
    }

    // Add device to the network
    public void AddDevice(Computer device)
    {
        devices.Add(device);
    }

    // Simulate interactions in the network
    public void SimulateNetwork()
    {
        // For simplicity, simulate connections and data transfer between devices
        foreach (var device in devices)
        {
            if (device is IConnectable connectableDevice)
            {
                foreach (var otherDevice in devices)
                {
                    if (otherDevice != device)
                    {
                        connectableDevice.Connect(otherDevice);
                        connectableDevice.TransferData(device, otherDevice, "Sample data");
                        connectableDevice.Disconnect(otherDevice);
                    }
                }
            }
        }
    }
}