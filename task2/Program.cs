using System;
using System.Collections.Generic;
using System.Net;


class Program
{
    static void Main()
    {
        // Create an instance of the network
        Network network = new Network();

        // Add some devices to the network
        network.AddDevice(new Server("192.168.1.1", 500, "Windows Server", 1000));
        network.AddDevice(new Workstation("192.168.1.2", 100, "Windows 10", "User1"));
        network.AddDevice(new Router("192.168.1.3", 200, "RouterOS"));

        // Simulate interactions in the network
        network.SimulateNetwork();

        Console.ReadLine(); // Pause to see the output
    }
}
