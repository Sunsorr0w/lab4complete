using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create an instance of the ecosystem
        Ecosystem ecosystem = new Ecosystem();

        // Add some organisms to the ecosystem
        ecosystem.AddOrganism(new Animal(100, 5, 10, "Lion"));
        ecosystem.AddOrganism(new Animal(50, 2, 5, "Rabbit"));
        ecosystem.AddOrganism(new Plant(10, 1, 3, "Tree"));
        ecosystem.AddOrganism(new Microorganism(5, 1, 1, "Bacteria"));

        // Simulate interactions in the ecosystem
        ecosystem.SimulateEcosystem();

        Console.ReadLine(); // Pause to see the output
    }
}
