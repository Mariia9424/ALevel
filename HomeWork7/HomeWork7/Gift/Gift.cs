public class Gift
{
    private List<Sweet> sweets = new List<Sweet>();

    public void AddSweet(Sweet sweet)
    {
        sweets.Add(sweet);
    }

    public double GetTotalWeight()
    {
        return sweets.Sum(s => s.Weight);
    }

    public void SortBySugarContent()
    {
        sweets = sweets.OrderBy(s => s.SugarContent).ToList();
    }

    public Sweet FindSweetBySugarContent(double sugarContent)
    {
        return sweets.FirstOrDefault(s => s.SugarContent == sugarContent);
    }

    public void DisplayContents()
    {
        foreach (var sweet in sweets)
        {
            Console.WriteLine(sweet.GetDescription());
        }
    }
}