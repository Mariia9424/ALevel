namespace HomeWork8;

    public class SaladIngredientBase : ISaladIngredient
    {
        public IVegetable Vegetable { get; private set; }

        public SaladIngredientBase(IVegetable vegetable)
        {
            Vegetable = vegetable;
        }
    }