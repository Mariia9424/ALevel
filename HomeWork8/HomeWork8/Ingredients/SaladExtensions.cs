namespace HomeWork8;
public static class SaladExtensions
{
    public static void DisplayIngredients(this Salad salad)
    {
        foreach (var ingredient in salad.ingredients)
        {
            Console.WriteLine(ingredient.Vegetable.Name);
        }
    }
}