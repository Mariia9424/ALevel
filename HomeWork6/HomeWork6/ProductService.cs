public class ProductService
{
    public Product[] GetProducts()
    {
        
        return new Product[]
        {
            new Product { Id = 1, Name = "Marker", Price = 8.37 },
            new Product { Id = 2, Name = "Pen", Price = 6.89 },
            new Product { Id = 3, Name = "Skotch", Price = 12.65 },
            new Product { Id = 4, Name = "Glue", Price = 9.38 },
            new Product { Id = 5, Name = "Binder", Price = 5.62 },
            new Product { Id = 6, Name = "Paper Clips", Price = 6.19 },
            new Product { Id = 7, Name = "Scissors", Price = 15.59 },
            new Product { Id = 8, Name = "Ruler", Price = 3.46 },
            new Product { Id = 9, Name = "Calculator", Price = 20.17 },
            new Product { Id = 10, Name = "Paper", Price = 15.28 },
            new Product { Id = 11, Name = "Pencil", Price = 6.37 }

        };
    }
}