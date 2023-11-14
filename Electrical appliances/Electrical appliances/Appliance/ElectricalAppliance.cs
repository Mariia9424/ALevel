public abstract class ElectricalAppliance : IElectricalAppliance
{
    public string Name { get; private set; }
    public double PowerConsumption { get; private set; }

    protected ElectricalAppliance(string name, double powerConsumption)
    {
        Name = name;
        PowerConsumption = powerConsumption;
    }

    public virtual void PlugIn()
    {
        Console.WriteLine($"{Name} is plugged in.");
    }
}