// Base class for living organisms
class LivingOrganism
{
    public double Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }

    // Constructor
    public LivingOrganism(double energy, int age, double size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }
}

// Interface for organisms that can reproduce
interface IReproducible
{
    void Reproduce();
}

// Interface for organisms that can hunt other organisms
interface IPredator
{
    void Hunt(LivingOrganism prey);
}

// Derived class for animals
class Animal : LivingOrganism, IReproducible, IPredator
{
    public string Species { get; set; }

    // Constructor
    public Animal(double energy, int age, double size, string species)
        : base(energy, age, size)
    {
        Species = species;
    }

    // Implementation of IReproducible interface
    public void Reproduce()
    {
        Console.WriteLine($"{Species} is reproducing.");
    }

    // Implementation of IPredator interface
    public void Hunt(LivingOrganism prey)
    {
        Console.WriteLine($"{Species} is hunting {prey.GetType().Name}.");
    }
}

// Derived class for plants
class Plant : LivingOrganism, IReproducible
{
    public string Type { get; set; }

    // Constructor
    public Plant(double energy, int age, double size, string type)
        : base(energy, age, size)
    {
        Type = type;
    }

    // Implementation of IReproducible interface
    public void Reproduce()
    {
        Console.WriteLine($"{Type} is reproducing.");
    }
}

// Derived class for microorganisms
class Microorganism : LivingOrganism, IReproducible
{
    public string Strain { get; set; }

    // Constructor
    public Microorganism(double energy, int age, double size, string strain)
        : base(energy, age, size)
    {
        Strain = strain;
    }

    // Implementation of IReproducible interface
    public void Reproduce()
    {
        Console.WriteLine($"{Strain} microorganism is reproducing.");
    }
}

// Class modeling the ecosystem
class Ecosystem
{
    private List<LivingOrganism> organisms;

    public Ecosystem()
    {
        organisms = new List<LivingOrganism>();
    }

    // Add organism to the ecosystem
    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    // Simulate interactions in the ecosystem
    public void SimulateEcosystem()
    {
        foreach (var organism in organisms)
        {
            // Reproduction for organisms implementing IReproducible
            if (organism is IReproducible reproducibleOrganism)
            {
                reproducibleOrganism.Reproduce();
            }

            // Hunting for organisms implementing IPredator
            if (organism is IPredator predator)
            {
                // Simulating hunting for prey in the ecosystem
                var preyCandidates = organisms.Where(o => o != organism).ToList();
                if (preyCandidates.Count > 0)
                {
                    var prey = preyCandidates[0]; // Simplified for example
                    predator.Hunt(prey);
                }
            }
        }
    }
}
