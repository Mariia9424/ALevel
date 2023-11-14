public static class ApplianceExtensions
{
    public static void SortByPowerConsumption(this IElectricalAppliance[] appliances)
    {
        Array.Sort(appliances, (a1, a2) => a1.PowerConsumption.CompareTo(a2.PowerConsumption));
    }

    public static IElectricalAppliance FindByPowerRange(this IElectricalAppliance[] appliances, double minPower, double maxPower)
    {
        return appliances.FirstOrDefault(appliance => appliance.PowerConsumption >= minPower && appliance.PowerConsumption <= maxPower);
    }
}