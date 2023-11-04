public class CartService
{
    public List<Product> cartItems;

    public CartService()
    {
        cartItems = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        if (cartItems.Count < 10)
        {
            cartItems.Add(product);
            Console.WriteLine($"{product.Name} has been added to the cart.");
        }
        else
        {
            Console.WriteLine("The cart is full. Cannot add more items.");
        }
    }

    public List<Product> GetCartContents()
    {
        return cartItems;
    }
}
