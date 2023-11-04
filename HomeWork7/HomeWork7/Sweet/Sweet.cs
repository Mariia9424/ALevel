public abstract class Sweet
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double SugarContent { get; set; }

    public Sweet(string name, double weight, double sugarContent)
    {
        Name = name;
        Weight = weight;
        SugarContent = sugarContent;
    }

    public abstract string GetDescription();
}
