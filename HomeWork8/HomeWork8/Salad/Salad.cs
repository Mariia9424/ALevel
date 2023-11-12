namespace HomeWork8;
public class Salad
{
    public ISaladIngredient[] ingredients;

    public Salad(ISaladIngredient[] ingredients)
    {
        this.ingredients = ingredients;
    }

    public int CalculateTotalCalories()
    {
        int totalCalories = 0;
        foreach (var ingredient in ingredients)
        {
            totalCalories += ingredient.Vegetable.Calories;
        }
        return totalCalories;
    }

    public void SortIngredientsByName()
    {
        Array.Sort(ingredients, (i1, i2) => i1.Vegetable.Name.CompareTo(i2.Vegetable.Name));
    }

    public ISaladIngredient[] SearchIngredientsByCalories(int minCalories, int maxCalories)
    {
        return Array.FindAll(ingredients, i => i.Vegetable.Calories >= minCalories && i.Vegetable.Calories <= maxCalories);
    }
}