public class Cookie : Sweet
{
    public string Type { get; set; }

    public Cookie(string name, double weight, double sugarContent, string type)
        : base(name, weight, sugarContent)
    {
        Type = type;
    }

    public override string GetDescription()
    {
        return $"Cookie: {Name}, Weight: {Weight}g, Sugar Content: {SugarContent}g, Type: {Type}";
    }
}