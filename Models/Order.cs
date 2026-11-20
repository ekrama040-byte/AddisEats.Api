namespace AddisEats.Api.Models;

public class Order
{
    public int Id { get; set; }
    public int RestaurantId { get; set; }
    public int MenuItemId { get; set; }
    public string CustomerName { get; set; } = "";
    public string DeliveryName { get; set; } = "";
    public string CustomerPhone { get; set; } = "";
    public decimal TotalAmount { get; set; }
    public int Quantity { get; set; }
    
}