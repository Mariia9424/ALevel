public class Chocolate : Sweet
{
    public int CocoaPercentage { get; set; }

    public Chocolate(string name, double weight, double sugarContent, int cocoaPercentage)
        : base(name, weight, sugarContent)
    {
        CocoaPercentage = cocoaPercentage;
    }

    public override string GetDescription()
    {
        return $"Chocolate: {Name}, Weight: {Weight}g, Sugar Content: {SugarContent}g, Cocoa Percentage: {CocoaPercentage}%";
    }
}
