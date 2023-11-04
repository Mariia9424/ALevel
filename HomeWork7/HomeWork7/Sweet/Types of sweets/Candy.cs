public class Candy : Sweet
{
    public string Flavor { get; set; }

    public Candy(string name, double weight, double sugarContent, string flavor)
        : base(name, weight, sugarContent)
    {
        Flavor = flavor;
    }

    public override string GetDescription()
    {
        return $"Candy: {Name}, Weight: {Weight}g, Sugar Content: {SugarContent}g, Flavor: {Flavor}";
    }
}
