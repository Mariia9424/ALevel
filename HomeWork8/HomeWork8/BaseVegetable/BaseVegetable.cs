namespace HomeWork8;
public abstract class BaseVegetable : IVegetable
{
    public string Name { get; private set; }
    public int Calories { get; private set; }

    public BaseVegetable(string name, int calories)
    {
        Name = name;
        Calories = calories;
    }

}