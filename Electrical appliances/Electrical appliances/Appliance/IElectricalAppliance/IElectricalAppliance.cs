public interface IElectricalAppliance
{
    string Name { get; }
    double PowerConsumption { get; }
    void PlugIn();
}