public class OrderService
{
    private int orderCounter = 1;

    public Order PlaceOrder(List<Product> cartItems)
    {
        Order order = new Order
        {
            OrderNumber = orderCounter++,
            Items = cartItems,
            OrderDate = DateTime.Now
        };
        return order;
    }
}