using AddisEats.Api.Models;
using AddisEats.Api.DTOs;
namespace AddisEats.Api.Services.OrderServices;

public class OrderService:IOrderService
{ 
    private readonly List<Order> _orders = new();

    public Order? GetById(int id)
    {
        return _orders.Where(object=>object.Id == id).FirstOrDefault();
    }
    public Order CreateOrder(CreateOrderDTO createOrder)
    {
        var newOrder = new Order
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
        return newOrder;
    }

}