using AddisEats.Api.Models;
using AddisEats.Api.DTOs;
using AddisEats.Api.Commons;
using AddisEats.Api.Services.RestaurantServices;

namespace AddisEats.Api.Services.OrderServices;

public class OrderService:IOrderService
{ 
    private static readonly List<Order> _orders = new();
    private readonly IRestaurantService _restaurantService;

    public OrderService(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }
    
    public Order? GetById(int id)
    {
        return _orders.Where(o =>o.Id == id).FirstOrDefault();
    }
    public Result<Order> CreateOrder(CreateOrderDTO createOrder)
    {
        var restaurant= _restaurantService.GetById(createOrder.RestaurantId);
        if(restaurant==null)
        {
            return Result<Order>.fail("Restaurant not found","selected restaurant is not available",404);
        }
        if(!restaurant.IsActive)
        {
            return Result<Order>.fail("Restaurant is not active","selected restaurant is not active",409);
        }

        Order newOrder = new Order
        {
            Id = _orders.Count + 1,
            RestaurantId = createOrder.RestaurantId,
            MenuItemId = createOrder.MenuItemId,
            CustomerName = createOrder.CustomerName,
            DeliveryName = createOrder.DeliveryName,
            CustomerPhone = createOrder.CustomerPhone,
            TotalAmount = createOrder.TotalAmount,
            Quantity = createOrder.Quantity
        };
        _orders.Add(newOrder);
        return Result<Order>.ok(newOrder);
    }

}