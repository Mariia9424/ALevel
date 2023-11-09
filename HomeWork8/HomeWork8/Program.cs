namespace HomeWork8;

    class Program
    {
        static void Main()
        {
            var salad = Ingredient.ComposeSalad();

            Console.WriteLine("Salad Contents:");
            salad.DisplayIngredients();

            Console.WriteLine($"\nTotal Calories: {salad.CalculateTotalCalories()}");

            salad.SortIngredientsByName();

            Console.WriteLine("\nSorted Salad Contents:");
            salad.DisplayIngredients();

            int minCalories = 10;
            int maxCalories = 30;

            var searchedIngredients = salad.SearchIngredientsByCalories(minCalories, maxCalories);

            Console.WriteLine($"\nIngredients between {minCalories} and {maxCalories} calories:");
            foreach (var ingredient in searchedIngredients)
            {
                Console.WriteLine(ingredient.Vegetable.Name);
            }
        }
    }
