namespace AddisEats.Api.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Catagory { get; set; }
    public decimal Price { get; set; }
    public decimal PriceWithVat => Price * 1.15m;
}


