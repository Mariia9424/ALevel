public class OnlineStoreApp
{
    private ProductService productService;
    private CartService cartService;
    private OrderService orderService;

    public OnlineStoreApp()
    {
        productService = new ProductService();
        cartService = new CartService();
        orderService = new OrderService();
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Online Store!");

        var products = productService.GetProducts();

    
        cartService.AddToCart(products[1]);
        cartService.AddToCart(products[3]);
        cartService.AddToCart(products[7]);
        cartService.AddToCart(products[6]);
        cartService.AddToCart(products[10]);
        cartService.AddToCart(products[5]);

        var order = orderService.PlaceOrder(cartService.GetCartContents());

        Console.WriteLine($"Order #{order.OrderNumber} has been generated.");
    }
}
