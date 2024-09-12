namespace Orders.Application.Model;

/// <summary>
/// Model Order
/// </summary>
public class Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}