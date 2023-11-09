namespace HomeWork8;
public class Ingredient
{
    public static Salad ComposeSalad()
    {
        var lettuce = new SaladIngredientBase(new LeafyGreenVegetable("Lettuce", 5));
        var carrot = new SaladIngredientBase(new RootVegetable("Carrot", 25));
        var broccoli = new SaladIngredientBase(new CruciferousVegetable("Broccoli", 20));

        var ingredients = new ISaladIngredient[] { lettuce, carrot, broccoli };

        return new Salad(ingredients);
    }
}