public class Order
{
    public int OrderNumber { get; set; }
    public List<Product> Items { get; set; }
    public DateTime OrderDate { get; set; }
}