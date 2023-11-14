namespace ElectricalAppliances;
class Program
{
    static void Main()
    {
        IElectricalAppliance[] appliances = {
            new KitchenAppliance("Refrigerator", 150, "Microwave", 75),
            new EntertainmentDevice("Smart TV", 80, "Sony Playstation", 65),
            new HomeLighting("Table Lamp", 20, "Bra", 18)
        };

        appliances.SortByPowerConsumption();

        Console.WriteLine("Appliances sorted by power consumption:");
        foreach (var appliance in appliances)
        {
            Console.WriteLine($"{appliance.Name} - Power Consumption: {appliance.PowerConsumption}W");
        }

        double minPower = 50;
        double maxPower = 100;
        var applianceInRange = appliances.FindByPowerRange(minPower, maxPower);

        if (applianceInRange != null)
        {
            Console.WriteLine($"\nAppliance in the specified power range ({minPower}-{maxPower}W): {applianceInRange.Name}");
        }
        else
        {
            Console.WriteLine($"\nNo appliance found in the specified power range ({minPower}-{maxPower}W).");
        }
    }
}