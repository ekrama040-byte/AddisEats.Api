namespace AddisEats.Api.DTOs;
public class RestaurantQuery
{
    public string? area { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 3;
}